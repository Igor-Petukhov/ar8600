using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ar8600
{
    public partial class RS232 : Form
    {
        public MainWindow main_form; // эта переменная будет содержать ссылку на форму MainWindow через неё можно менять элементы в главном окне
        public RS232()
        {
            InitializeComponent();

            comboBox_PortName.Items.AddRange(SerialPort.GetPortNames());
            comboBox_Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboBox_StopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboBox_Handshake.Items.AddRange(Enum.GetNames(typeof(Handshake)));

            SetDefaultSettings();

        }

        private void button_resetDefault_Click(object sender, EventArgs e)
        {
            SetDefaultSettings();
        }

        private void SetDefaultSettings()
        {
            comboBox_PortName.SelectedItem = "COM1";
            comboBox_BaudRate.SelectedItem = "9600";
            comboBox_DataBits.SelectedItem = "8";
            comboBox_Parity.SelectedItem = "None";
            comboBox_StopBits.SelectedItem = "Two";
            comboBox_Handshake.SelectedItem = "XOnXOff";
            uslovie_activation_ok_button();
        }

        public void button_ok_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("settings.txt", FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(comboBox_PortName.SelectedItem);
                    sw.WriteLine(comboBox_BaudRate.SelectedItem);
                    sw.WriteLine(comboBox_Parity.SelectedItem);
                    sw.WriteLine(comboBox_StopBits.SelectedItem);
                    sw.WriteLine(comboBox_DataBits.SelectedItem);
                    sw.WriteLine(comboBox_Handshake.SelectedItem);
                }
            }
            main_form.SetConnection();
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uslovie_activation_ok_button()
        {
            if (
                    (comboBox_PortName.SelectedItem != null) &&
                    (comboBox_BaudRate.SelectedItem != null) &&
                    (comboBox_DataBits.SelectedItem != null) &&
                    (comboBox_Parity.SelectedItem != null) &&
                    (comboBox_StopBits.SelectedItem != null) &&
                    (comboBox_Handshake.SelectedItem != null)
               )
                button_ok.Enabled = true;
            else
                button_ok.Enabled = false;
        }

        private void comboBox_any_SelectedIndexChanged(object sender, EventArgs e)
        {
            uslovie_activation_ok_button();
        }

    }
}
