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

        CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        CancellationToken token;

        //для записи звука
        static WaveFileWriter waveFile;
        WaveInEvent waveSource;
        public MainWindow()
        {
            token = cancelTokenSource.Token; //для особой работы с ком портом

            InitializeComponent();
            SetConnection();

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
            Send_to_port("\r");
        }


        private void Send_to_port(string command)
        {
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
            }
            catch (Exception e)
            {
                result = false;
                MessageBox.Show(e.Message);
            }
            Console.WriteLine(Encoding.ASCII.GetString(recvBuffer));
            return result;
        }

        private void button_get_status_Click(object sender, EventArgs e)
        {
            Send_to_port("RX\r");
        }
    }
}
