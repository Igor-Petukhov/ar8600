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

namespace ar8600
{
    public partial class MainWindow : Form
    {
        public static SerialPort _serialPort = new SerialPort();
        static WaveFileWriter waveFile;
        WaveInEvent waveSource;
        public MainWindow()
        {
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

        }

        private void button_start_rec_Click(object sender, EventArgs e)
        {
            waveFile = new WaveFileWriter("Recordings\\Record_" + DateTime.Now.ToString().Replace(" ", "_").Replace(":", "'") + ".wav", waveSource.WaveFormat);
            waveSource.StartRecording();

            label_rec.Text = "RECORDING";

            button_start_rec.Enabled = false;
            button_stop_rec.Enabled = true;
        }

        static void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            waveFile.WriteData(e.Buffer, 0, e.BytesRecorded);
        }

        private void button_stop_rec_Click(object sender, EventArgs e)
        {
            waveSource.StopRecording();
            waveFile.Dispose();

            label_rec.Text = "";

            button_start_rec.Enabled = true;
            button_stop_rec.Enabled = false;
        }
    }
}
