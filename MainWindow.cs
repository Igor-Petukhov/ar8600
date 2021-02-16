using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using NAudio.Wave;
using System.Threading;

namespace ar8600
{
    public partial class MainWindow : Form
    {
        //для работы с ком портом
        public static SerialPort _serialPort = new SerialPort(); 
        static byte[] send_data = new byte[50];
        static byte[] receive_data = new byte[50];
        int received_bytes;
        int waitingForStart = 500;
        int waitForEnd = 500;
        int retry = 20; //колличество попыток отправить команду пока не получим ожидаемый ответ

        CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        CancellationToken token;

        //Для таймера - счетчик секунд аудиозаписи
        int seconds = 0;

        //для записи звука
        static WaveFileWriter waveFile;
        WaveInEvent waveSource;

        //Переменные в которых храним снятые данные
        Channel current_frequency = new Channel();
        static decimal curr_step = -1;
        List<Channel> freq_base = new List<Channel>();

        //Название текстового файла со списком частот для сканирования
        public static string file_name = "scan_list.txt";

        public MainWindow()
        {
            token = cancelTokenSource.Token; //для особой работы с ком портом

            InitializeComponent();
            SetConnection();

            //Заполним значения в килогерцах выбора шага ручной подстройки частоты с помощью кнопочек
            comboBox_step.Items.Add((decimal)0.05);
            comboBox_step.Items.Add((decimal)0.1);
            comboBox_step.Items.Add((decimal)0.2);
            comboBox_step.Items.Add((decimal)0.5);
            comboBox_step.Items.Add((decimal)1);
            comboBox_step.Items.Add((decimal)2);
            comboBox_step.Items.Add((decimal)5);
            comboBox_step.Items.Add((decimal)6.25);
            comboBox_step.Items.Add((decimal)8.33);
            comboBox_step.Items.Add((decimal)9);
            comboBox_step.Items.Add((decimal)10);
            comboBox_step.Items.Add((decimal)12.5);
            comboBox_step.Items.Add((decimal)20);
            comboBox_step.Items.Add((decimal)25);
            comboBox_step.Items.Add((decimal)30);
            comboBox_step.Items.Add((decimal)50);
            comboBox_step.Items.Add((decimal)100);
            
            //Тут необходимое для записи звука из ручного управления
            waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(44100, 1);
            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
        }

        private void button_set_rs232_Click(object sender, EventArgs e)
        {
            //Создаём форму и показываем её
            RS232 form_RS232 = new RS232();
            form_RS232.main_form = this;
            form_RS232.ShowDialog();
        }

        public void SetConnection()
        {
            if (!File.Exists("settings.txt"))
            {
                label_check_settings.BackColor = Color.Red;
                label_check_settings.ForeColor = Color.White;
                label_check_settings.Font = new Font(label_check_settings.Font, label_check_settings.Font.Style | FontStyle.Bold);
                label_check_settings.Text = "!!! Необходимо настроить подключение !!!";
            }
            else
            {
                Console.WriteLine("Считываются из конфигурационного файла настройки подключения");
                try
                {
                    using (FileStream fs = new FileStream("settings.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                        {
                            _serialPort.PortName = sr.ReadLine(); //Имя порта
                            _serialPort.BaudRate = Int32.Parse(sr.ReadLine());
                            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), sr.ReadLine(), true);
                            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), sr.ReadLine(), true);
                            _serialPort.DataBits = Int32.Parse(sr.ReadLine());
                            _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), sr.ReadLine(), true);

                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                label_check_settings.BackColor = SystemColors.Control;
                label_check_settings.ForeColor = SystemColors.ControlText;
                label_check_settings.Font = new Font(label_set_parameters.Font,label_set_parameters.Font.Style);
                label_check_settings.Text = "Настройки успешно загружены";
                Console.WriteLine("Считывание завершено.");
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Open(); //Открыть com-port
            }
            catch (Exception ex_open_comport)
            {
                MessageBox.Show(ex_open_comport.Message);
                return;
            }
            if (_serialPort.IsOpen)
            {
                for (int i = 0; i < retry; i++)
                {
                    Send_to_port("RX\r"); //Запросить текущую частоту, модуляцию, аттенюацию
                    if (Encoding.ASCII.GetString(receive_data).Substring(0, 2) == "VF")
                        break;
                    if (i == retry - 1)
                    {
                        MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                        return;
                    }
                    Send_to_port("VF\r"); //Включить режим VFO
                }
                Update_GUI();
            }
        }

        private void Send_to_port(string command)
        {
            Console.WriteLine("Отправляю:");
            Console.WriteLine(command);
            send_data = Encoding.ASCII.GetBytes(command);
            //New fast method
            SendRecv(_serialPort, send_data, waitingForStart, waitForEnd, token, ref receive_data, out received_bytes);

            ////My simple method
            //send_data = Encoding.ASCII.GetBytes(command); //Перевести строку в байты
            //try
            //{
            //    _serialPort.Write(send_data, 0, send_data.Length); //Отправить в открытый порт
            //}
            //catch (Exception ex_open_comport)
            //{
            //    MessageBox.Show(ex_open_comport.Message);
            //}
        }

        private void button_start_rec_Click(object sender, EventArgs e)
        {
            try
            {
                waveFile = new WaveFileWriter("Recordings\\Record_" + DateTime.Now.ToString().Replace(" ", "_").Replace(":", "'") + ".wav", waveSource.WaveFormat);
                waveSource.StartRecording();

                label_rec.Text = "RECORDING";

                button_start_rec.Enabled = false;
                button_stop_rec.Enabled = true;
            }
            catch (Exception ex_recsound)
            {
                MessageBox.Show(ex_recsound.Message);
            }

            label_seconds.Text = "Секунд: " + seconds;
            timer1.Start();
        }

        static void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            waveFile.WriteData(e.Buffer, 0, e.BytesRecorded);
        }

        //остановить запись
        private void button_stop_rec_Click(object sender, EventArgs e)
        {
            try
            {
                waveSource.StopRecording();
                waveFile.Dispose();

                label_rec.Text = "";

                button_start_rec.Enabled = true;
                button_stop_rec.Enabled = false;
            }
            catch (Exception ex_stoprecsound)
            {
                MessageBox.Show(ex_stoprecsound.Message);
            }
            timer1.Stop();
            seconds = 0;
            label_seconds.Text = "";
        }

        //выключить сканер
        private void button_turn_off_Click(object sender, EventArgs e)
        {
            Send_to_port("QP\r");
        }

        //закрыть соединение
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            Send_to_port("EX\r");
            try
            {
                _serialPort.Close(); //Закрыть com-port
            }
            catch (Exception ex_open_comport)
            {
                MessageBox.Show(ex_open_comport.Message);
                return;
            }
                progressBar_s_meter.Value = 0;
                label_Level_current.Text = "0";
                current_frequency.Squelch = 0;
                numericUpDown.Value = (decimal)103.3;
        }

        /// <summary>
        /// Отправка/приём данных через SerialPort.
        /// </summary>
        /// <param name="connection">SerialPort, используемый для связи.</param>
        /// <param name="sendBuffer">Массив отправляемых байт.</param>
        /// <param name="waitingForStart">Время ожидания от отправки до начала ответа.</param>
        /// <param name="waitForEnd">Время ожидания после завершения ответа.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <param name="recvBuffer">Массив буфера для приёма байт.</param>
        /// <param name="received">Количество принятых байт.</param>
        /// <returns>Получен ли какой-нибудь ответ.</returns>
        public bool SendRecv(SerialPort connection, byte[] sendBuffer, int waitingForStart, int waitForEnd, CancellationToken cancellationToken, ref byte[] recvBuffer, out int received)
        {
            bool result = false;
            received = -1;

            //Очистим буфер ответа сканера, что бы не накладывались ответы
            Array.Clear(recvBuffer, 0, recvBuffer.Length);
            Console.WriteLine("Очистил буфер ответа сканера");

            try
            {
                // Порт должен быть открыт.
                if (connection.IsOpen)
                {
                    // Сброс буферов.
                    connection.DiscardInBuffer();
                    connection.DiscardOutBuffer();

                    if (connection.BytesToRead > 0)
                    {
                        connection.ReadExisting();
                    }

                    // Установка таймаута начала ответа.
                    connection.ReadTimeout = waitingForStart;

                    // Отправка данных.
                    connection.Write(sendBuffer, 0, sendBuffer.Length);

                    int readed = 0;

                    try
                    {
                        // Ожидание первого байта. Если ничего не придёт за waitingForStart мс, то вылетит TimeoutException.
                        recvBuffer[readed++] = Convert.ToByte(connection.ReadByte());

                        // Установка таймаута для определения завершения ответа.
                        connection.ReadTimeout = waitForEnd;

                        try
                        {
                            // Временный буфер для приёма частями.
                            byte[] temp = new byte[16];

                            do
                            {
                                // Чтение и заполнение буфера.
                                // Если ничего не принято, то вылетит TimeoutException.
                                // Если считано меньше или равно размеру буфера, это число возвращается функцией.
                                int b = connection.Read(temp, 0, 16);

                                // Копирование в выходной буфер.
                                for (int i = 0; i < b; i++)
                                {
                                    recvBuffer[readed++] = temp[i];
                                }

                                // Повтор до явной отмены.
                                // Также, выход доступен по таймауту чтения.
                            } while (!cancellationToken.IsCancellationRequested);
                        }
                        catch (TimeoutException)
                        {
                        }
                        finally
                        {
                            // Количество считанного.
                            received = readed;
                            // Возвращаемый результат: принято ли что-нибудь.
                            result = readed > 0;
                        }
                    }
                    catch (TimeoutException)
                    {
                    }
                }
                else //если порт закрыт
                {
                    MessageBox.Show("Соединение не установлено!");
                }
            }
            catch (Exception e)
            {
                result = false;
                MessageBox.Show(e.Message);
            }
            Console.WriteLine("команду отправил");
            Console.WriteLine("Ответ");
            Console.WriteLine(Encoding.ASCII.GetString(recvBuffer));
            Console.WriteLine("Принял ответ");
            textBox_scanner_answer.Text = Encoding.ASCII.GetString(recvBuffer);
            return result;
        }

        private void button_get_status_Click(object sender, EventArgs e)
        {
            Update_GUI();
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            Send_to_port(Convert.ToChar(28) + "\r"); //ASCII control code
            Update_GUI();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            Send_to_port(Convert.ToChar(29) + "\r"); //ASCII control code
            Update_GUI();
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            Send_to_port(Convert.ToChar(30) + "\r"); //ASCII control code
            Update_GUI();
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            Send_to_port(Convert.ToChar(31) + "\r"); //ASCII control code
            Update_GUI();
        }

        void button_set_modulation(string send, string code)
        {
            if ((current_frequency.Modulation != code) && (current_frequency.Modulation != ""))
            {
                for (int i = 0; i < retry; i++)
                {
                    Send_to_port(send);
                    Update_GUI();
                    if (current_frequency.Modulation == code)
                        return;
                    if (i == retry - 1)
                    {
                        MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                        return;
                    }
                }
            }
        }

        private void button_WFM_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD0\r", "0");
        }

        private void button_NFM_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD1\r", "1");
        }

        private void button_AM_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD2\r", "2");
        }

        private void button_USB_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD3\r", "3");
        }

        private void button_LSB_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD4\r", "4");
        }

        private void button_CW_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD5\r", "5");
        }

        private void button_SFM_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD6\r", "6");
        }

        private void button_WAM_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD7\r", "7");
        }

        private void button_NAM_Click(object sender, EventArgs e)
        {
            button_set_modulation("MD8\r", "8");
        }

        private void button_set_frequency_Click(object sender, EventArgs e)
        {
            double d_tmp = double.Parse(numericUpDown.Value.ToString());
            string tmp = d_tmp.ToString().Replace(',','.');

            if ((GetDecimalDigitsCount(d_tmp)) > 5)
            {
                MessageBox.Show("Точность настройки частоты должна иметь " +
                    "не более 5-ти знаков после запятой. Причём, пятый знак " +
                    "может быть либо \"0\", либо \"5\" - это означает, что частота " +
                    "кончается на 50 Гц или 0 Гц.");
                return;
            }
            if ((GetDecimalDigitsCount(d_tmp)) == 5)
                tmp += "0";
            if ((GetDecimalDigitsCount(d_tmp)) == 4)
                tmp += "00";
            if ((GetDecimalDigitsCount(d_tmp)) == 3)
                tmp += "000";
            if ((GetDecimalDigitsCount(d_tmp)) == 2)
                tmp += "0000";
            if ((GetDecimalDigitsCount(d_tmp)) == 1)
                tmp += "00000";
            if ((GetDecimalDigitsCount(d_tmp)) == 0)
                tmp += ".00000";

            if (d_tmp < 1000)
            {
                tmp = "0" + tmp;
                if (d_tmp < 100)
                {
                    tmp = "0" + tmp;
                    if (d_tmp < 10)
                    {
                        tmp = "0" + tmp;
                    }
                }
            }
            else
            {
                if ((numericUpDown.Value > 3000) || (double.Parse(numericUpDown.Value.ToString()) < 0.001))
                {
                    MessageBox.Show("Частота вне диапазона!");
                    return;
                }
            }

            //Настраиваемся на частоту
            Send_to_port("RF" + tmp + "\r");

            //Выставляем модуляцию из радиокнопок
            //Проверим все радиокнопки в групбоксе модуляция
            foreach (Control c in groupBox_modulation.Controls)  // цикл по дочерним
            {
                // Проверям, является ли элемент радиокнопкой путем преобр. типов
                var r = c as RadioButton;
                if (r != null)  // это радиокнопка
                {
                    if (r.Checked)
                    {
                        string tmp_str_modulation = "";
                        Check_radiobutton(r, ref tmp_str_modulation);
                        Send_to_port("MD" + tmp_str_modulation + "\r");
                    }
                }
            }

            //Если чекбокс выбран - включаем аттенюатор
            if (checkBox_ATT.Checked)
            {
                Send_to_port("AT1\r");
            }
            else
            {
                Send_to_port("AT0\r");
            }

            //Обновим интерфейс что бы видеть дошли ли наши команды сканеру
            Update_GUI();
        }


        private void numericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_set_frequency_Click(sender, e);
        }

        private void comboBox_step_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp = comboBox_step.SelectedItem.ToString().Replace(',', '.');
            double d_tmp = double.Parse(comboBox_step.SelectedItem.ToString());

            numericUpDown.Increment = (decimal)d_tmp / 1000;

            if (d_tmp < 100)
            {
                tmp = "0" + tmp;
                if (d_tmp < 10)
                {
                    tmp = "0" + tmp;
                }
            }
            if ((GetDecimalDigitsCount(d_tmp)) == 0)
                tmp += ".00";
            if ((GetDecimalDigitsCount(d_tmp)) == 1)
                tmp += "0";
            
            Send_to_port("ST" + tmp + "\r");
            Update_GUI(); //Обновим интерфейс
        }

        //from internet
        static int GetDecimalDigitsCount(double number)
        {
            string str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." });
            return str.Contains(".") ? str.Remove(0, Math.Truncate(number).ToString().Length + 1).Length : 0;
        }

        private void button_AT_on_Click(object sender, EventArgs e)
        {
            Send_to_port("AT1\r");
            Update_GUI();
        }

        private void button_AT_off_Click(object sender, EventArgs e)
        {
            Send_to_port("AT0\r");
            Update_GUI();
        }

        private void button_freq_level_Click(object sender, EventArgs e)
        {
            Send_to_port("LC1\r");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds += 1;
            label_seconds.Text = "Секунд: " + seconds;
        }

        void Update_GUI()
        {
            Update_GUI_part_1();
            Update_GUI_part_2_signal_level();
        }

        private void Update_GUI_part_1()
        {
            if (_serialPort.IsOpen)
            {
                //пока не получим полный ответ, а он может не дойти по каким-то причинам
                //или пока не исчерпается кол-во попыток
                for (int i = 0; i < retry; i++)
                {
                    Send_to_port("RX\r"); //Запросить текущую частоту, модуляцию, аттенюацию
                    if (Encoding.ASCII.GetString(receive_data).Substring(0, 5) == "VF RF")
                    {
                        current_frequency.Frequency = decimal.Parse(Encoding.ASCII.GetString(receive_data).Substring(5, 4) + "," + Encoding.ASCII.GetString(receive_data).Substring(9, 6));
                        curr_step = decimal.Parse(Encoding.ASCII.GetString(receive_data).Substring(18, 3) + "," + Encoding.ASCII.GetString(receive_data).Substring(21, 3));
                        current_frequency.Modulation = Encoding.ASCII.GetString(receive_data).Substring(31, 1);
                        current_frequency.Attenuation = Encoding.ASCII.GetString(receive_data).Substring(33, 3);
                        break;
                    }
                    if (i == retry - 1)
                    {
                        MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                        return;
                    }
                }

                //вносим ответ в интерфейс
                try
                {
                    //вносим в интерфейс частоту если там выбрана другая
                    if (numericUpDown.Value != current_frequency.Frequency)
                    {
                        numericUpDown.Value = current_frequency.Frequency;
                        numericUpDown.Update();
                    }

                    //вносим в интерфейс модуляцию
                    switch (current_frequency.Modulation)
                    {
                        case "0":
                            radioButton_WFM.Checked = true;
                            break;
                        case "1":
                            radioButton_NFM.Checked = true;
                            break;
                        case "2":
                            radioButton_AM.Checked = true;
                            break;
                        case "3":
                            radioButton_USB.Checked = true;
                            break;
                        case "4":
                            radioButton_LSB.Checked = true;
                            break;
                        case "5":
                            radioButton_CW.Checked = true;
                            break;
                        case "6":
                            radioButton_SFM.Checked = true;
                            break;
                        case "7":
                            radioButton_WAM.Checked = true;
                            break;
                        case "8":
                            radioButton_NAM.Checked = true;
                            break;
                        default:
                            break;
                    }

                    //вносим в интерфейс аттенюацию
                    switch (current_frequency.Attenuation)
                    {
                        case "AT0":
                            checkBox_ATT.Checked = false;
                            current_frequency.Attenuation = "AT0";
                            break;
                        case "AT1":
                            checkBox_ATT.Checked = true;
                            current_frequency.Attenuation = "AT1";
                            break;
                        default:
                            break;
                    }

                    //вносим в интерфейс шаг подстройки частоты если там стоит другой
                    if (curr_step != -1)
                    {
                        comboBox_step.SelectedItem = curr_step;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Соединение не установлено!");
            }
        }

        private void Update_GUI_part_2_signal_level()
        {
            if (_serialPort.IsOpen)
            {
                //Обновим данные об уровне сигнала
                //пока не получим полный ответ, а он может не дойти по каким-то причинам
                //или пока не исчерпается кол-во попыток
                for (int i = 0; i < retry; i++)
                {
                    Send_to_port("LM\r"); //Запросить текущий уровень сигнала
                    if (Encoding.ASCII.GetString(receive_data).Substring(0, 2) == "LM")
                        break;
                    if (i == retry - 1)
                    {
                        MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                        return;
                    }
                }
                //Вносим уровень сигнала в интерфейс
                try
                {
                    string tmp_str = Encoding.ASCII.GetString(receive_data).Remove(0, 3);
                    label_Level_current.Text = tmp_str;
                    current_frequency.Squelch = Int32.Parse(tmp_str);
                    progressBar_s_meter.Value = current_frequency.Squelch;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Соединение не установлено!");
            }
        }

        private void button_save_frequency_Click(object sender, EventArgs e)
        {
            Form_frequency_save frequency_Save = new Form_frequency_save(current_frequency, file_name);

            frequency_Save.ShowDialog();
        }

        //Внесёт в переданую строку модуляцию, к которой надо дописать слева MD и можно отправлять в порт
        public static void Check_radiobutton(RadioButton r, ref string str_modulation)
        {
            switch (r.Text)
            {
                case "WFM":
                    str_modulation = "0";
                    break;
                case "NFM":
                    str_modulation = "1";
                    break;
                case "AM":
                    str_modulation = "2";
                    break;
                case "USB":
                    str_modulation = "3";
                    break;
                case "LSB":
                    str_modulation = "4";
                    break;
                case "CW":
                    str_modulation = "5";
                    break;
                case "SFM":
                    str_modulation = "6";
                    break;
                case "WAM":
                    str_modulation = "7";
                    break;
                case "NAM":
                    str_modulation = "8";
                    break;
                default:
                    str_modulation = "";
                    break;
            }
        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            //Считываем в память файл со списком частот для сканирования
            if (File.Exists("scan_list.txt"))
            {
                try
                {
                    freq_base.Clear();
                    using (FileStream fs = new FileStream("scan_list.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                        {
                            string[] arr_str_tmp;
                            while (!sr.EndOfStream)
                            {
                                arr_str_tmp = sr.ReadLine().Split('\t');
                                freq_base.Add(new Channel(decimal.Parse(arr_str_tmp[0]), arr_str_tmp[1], arr_str_tmp[2], Int32.Parse(arr_str_tmp[3])));
                                Console.WriteLine(arr_str_tmp[0]);
                                Console.WriteLine(arr_str_tmp[1]);
                                Console.WriteLine(arr_str_tmp[2]);
                                Console.WriteLine(arr_str_tmp[3]);
                                Console.WriteLine("====================");
                            }
                        }
                    }
                }
                catch (Exception ExReadFreqBase)
                {
                    Console.WriteLine(ExReadFreqBase.Message);
                }
            }
            else
            {
                MessageBox.Show("Не удаётся найти файл \"scan_list.txt\"");
            }

            if (_serialPort.IsOpen)
            {
                //Узнаём какие сейчас выставлены параметры в сканере
                Update_GUI_part_1(); //Считает со сканера данные в current_frequency
                Console.WriteLine(current_frequency.Frequency);
                Console.WriteLine(current_frequency.Modulation);
                Console.WriteLine(current_frequency.Attenuation);

                //Включаем ответ с уровнем сигнала после каждой перестройки частоты
                for (int i = 0; i < retry; i++)
                {
                    Send_to_port("LC1\r\n");
                    Send_to_port("LC\r\n"); //запрошу ответ, так надёжнее. Иначе приходит ответ \r\n
                    if (Encoding.ASCII.GetString(receive_data).Substring(0, 2) == "LC")
                        break;
                    if (i == retry - 1)
                    {
                        MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                        return;
                    }
                }

                for (int j = 0; j < 10; j++) //Кол-во итераций сканирования. В будущем доработать какой-то токен завершения сканирования!!!!!!!!
                {
                    try
                    {
                        for (int counter = 0; counter < freq_base.Count; counter++)
                        {
                            //Сравниваем считаные параметры с необходимыми параметрами для первой частоты
                            //Если есть отличия - настраиваем сначала параметры
                            if (freq_base[counter].Attenuation != current_frequency.Attenuation)
                            {
                                switch (freq_base[counter].Attenuation)
                                {
                                    case "AT0":
                                        for (int i = 0; i < retry; i++)
                                        {
                                            Send_to_port("AT0\r");
                                            Update_GUI_part_1();
                                            if (freq_base[counter].Attenuation == current_frequency.Attenuation)
                                                break;
                                            if (i == retry - 1)
                                            {
                                                MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                                                return;
                                            }
                                        }
                                        break;
                                    case "AT1":
                                        for (int i = 0; i < retry; i++)
                                        {
                                            Send_to_port("AT1\r");
                                            Update_GUI_part_1();
                                            if (freq_base[counter].Attenuation == current_frequency.Attenuation)
                                                break;
                                            if (i == retry - 1)
                                            {
                                                MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                                                return;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }

                            if (freq_base[counter].Modulation != "MD" + current_frequency.Modulation)
                            {
                                for (int i = 0; i < retry; i++)
                                {
                                    Send_to_port(freq_base[counter].Modulation + "\r\n");
                                    Update_GUI_part_1();
                                    if (freq_base[counter].Modulation == "MD" + current_frequency.Modulation)
                                        break;
                                    if (i == retry - 1)
                                    {
                                        MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                                        return;
                                    }
                                }
                            }

                            if (freq_base[counter].Frequency != current_frequency.Frequency)
                            {
                                double d_tmp = (double)freq_base[counter].Frequency;
                                string tmp = d_tmp.ToString().Replace(',', '.');

                                if ((GetDecimalDigitsCount(d_tmp)) > 5)
                                {
                                    MessageBox.Show("Точность настройки частоты " + d_tmp.ToString() + " должна иметь " +
                                        "не более 5-ти знаков после запятой. Причём, пятый знак " +
                                        "может быть либо \"0\", либо \"5\" - это означает, что частота " +
                                        "кончается на 50 Гц или 0 Гц.");
                                    return;
                                }
                                if ((GetDecimalDigitsCount(d_tmp)) == 5)
                                    tmp += "0";
                                if ((GetDecimalDigitsCount(d_tmp)) == 4)
                                    tmp += "00";
                                if ((GetDecimalDigitsCount(d_tmp)) == 3)
                                    tmp += "000";
                                if ((GetDecimalDigitsCount(d_tmp)) == 2)
                                    tmp += "0000";
                                if ((GetDecimalDigitsCount(d_tmp)) == 1)
                                    tmp += "00000";
                                if ((GetDecimalDigitsCount(d_tmp)) == 0)
                                    tmp += ".00000";

                                if (d_tmp < 1000)
                                {
                                    tmp = "0" + tmp;
                                    if (d_tmp < 100)
                                    {
                                        tmp = "0" + tmp;
                                        if (d_tmp < 10)
                                        {
                                            tmp = "0" + tmp;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((freq_base[counter].Frequency > 3000) || ((double)freq_base[counter].Frequency < 0.001))
                                    {
                                        MessageBox.Show("Частота вне диапазона!");
                                        return;
                                    }
                                }

                                for (int i = 0; i < retry; i++)
                                {
                                    //Настраиваемся на частоту
                                    Send_to_port("RF" + tmp + "\r");
                                    current_frequency.Frequency = decimal.Parse(Encoding.ASCII.GetString(receive_data).Substring(13, 4) + "," + Encoding.ASCII.GetString(receive_data).Substring(17, 6));
                                    if (freq_base[counter].Frequency == current_frequency.Frequency)
                                        break;
                                    if (i == retry - 1)
                                    {
                                        MessageBox.Show("Похоже, соединение прервано. Проверьте соединительный кабель.");
                                        return;
                                    }
                                }

                                current_frequency.Squelch = Int32.Parse(Encoding.ASCII.GetString(receive_data).Substring(4, 3));
                                Console.WriteLine(Encoding.ASCII.GetString(receive_data).Substring(4, 3));

                                //Если получили уровень сигнала выше, чем в базе - то записать звук
                                if (freq_base[counter].Squelch < current_frequency.Squelch)
                                {
                                    Console.WriteLine("-------start audio recording for 3 seconds------");
                                    if (!Directory.Exists("Recordings"))
                                        Directory.CreateDirectory("Recordings");
                                    waveFile = new WaveFileWriter("Recordings\\" + "Record_" + current_frequency.Frequency + "MHz_" + DateTime.Now.ToString().Replace(" ", "_").Replace(":", "'") + ".wav", waveSource.WaveFormat);
                                    waveSource.StartRecording();
                                    Thread.Sleep(3000);
                                    waveSource.StopRecording();
                                    waveFile.Dispose();
                                }
                            }
                        }
                    }
                    catch (System.FormatException err)
                    {
                        MessageBox.Show(err.Message + " Проверь положение регулятора SQL (squelch) на сканере! Он должен стоять в положении минимум! (Выкрути до упора ПРОТИВ часовой стрелки)");
                    }
                }
            }
            else
            {
                MessageBox.Show("Соединение не установлено!");
            }

        }

        private void button_change_freq_list_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open_file = new OpenFileDialog();
                open_file.InitialDirectory = ".";
                open_file.Filter = "Text Files|*.txt|All Files|*.*";
                open_file.FilterIndex = 1;// по умолчанию фильтруются текстовые файлы
                if (open_file.ShowDialog() == DialogResult.OK)
                {
                    file_name = open_file.FileName;
                    if (Path.GetFileName(open_file.FileName).Length < 15)
                    {
                        label_list_freq_name.Text = Path.GetFileName(open_file.FileName);
                    }
                    else
                    {
                        label_list_freq_name.Text = Path.GetFileName(open_file.FileName).Substring(0,15);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }


    //Создаём вертикальный прогресс бар для красивой индикации уровня сигнала
    //from internet
    public class VerticalProgressBar : ProgressBar
    {
    protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}
