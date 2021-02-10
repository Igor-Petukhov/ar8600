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

namespace ar8600
{
    public partial class Form_frequency_save : Form
    {
        public Channel channel_global { get; set; }
        public Form_frequency_save(Channel channel)
        {
            InitializeComponent();

            channel_global = (Channel)channel.Clone();

            try
            {
                //вносим в интерфейс частоту
                numericUpDown.Value = channel.Frequency;
                numericUpDown.Update();

                //вносим в интерфейс модуляцию
                switch (channel.Modulation)
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
                switch (channel.Attenuation)
                {
                    case "AT0":
                        checkBox_ATT.Checked = false;
                        break;
                    case "AT1":
                        checkBox_ATT.Checked = true;
                        break;
                    default:
                        break;
                }

                //Вносим уровень сигнала в интерфейс
                progressBar_s_meter.Value = channel.Squelch;
                label_Level_current.Text = channel.Squelch.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void button_add_to_base_Click(object sender, EventArgs e)
        {
            int tmp_squelch;
            if (!Int32.TryParse(textBox_squelch_level.Text, out tmp_squelch))
            {
                MessageBox.Show("Ошибка в поле SQUELCH!");
                return;
            }
            else 
            {
                channel_global.Squelch = tmp_squelch;
            }

            channel_global.Frequency = numericUpDown.Value;
            if (checkBox_ATT.Checked)
                channel_global.Attenuation = "AT1";
            else
                channel_global.Attenuation = "AT0";

            //проверим заполнена ли модуляция
            bool is_modulation_set = false;
            string mod = "";
            foreach (RadioButton item in groupBox_modulation.Controls)
            {
                if (item.Checked)
                {
                    is_modulation_set = true;
                    MainWindow.Check_radiobutton(item, ref mod);
                    channel_global.Modulation = "MD" + mod;
                    break;
                }
            }

            if (is_modulation_set)
            {
                using (FileStream fs = new FileStream("scan_list.txt", FileMode.Append, FileAccess.Write, FileShare.Read))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        sw.WriteLine(
                            channel_global.Frequency + "\t" +
                            channel_global.Modulation + "\t" +
                            channel_global.Attenuation + "\t" +
                            channel_global.Squelch);
                        MessageBox.Show("Добавлено в базу!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбрана модуляция!");
            }
            
        }

        private void trackBar_Squelch_Scroll(object sender, EventArgs e)
        {
            textBox_squelch_level.Text = trackBar_Squelch.Value.ToString();
        }

        private void textBox_squelch_level_TextChanged(object sender, EventArgs e)
        {
            int tmp_int;
            bool tmp = false;
            tmp = Int32.TryParse(textBox_squelch_level.Text, out tmp_int);
            if (tmp)
            {
                trackBar_Squelch.Value = tmp_int;
            }

        }
    }
}
