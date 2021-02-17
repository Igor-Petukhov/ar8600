
namespace ar8600
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button_set_rs232 = new System.Windows.Forms.Button();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.label_check_settings = new System.Windows.Forms.Label();
            this.label_set_parameters = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_turn_off = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_start_rec = new System.Windows.Forms.Button();
            this.button_stop_rec = new System.Windows.Forms.Button();
            this.label_rec = new System.Windows.Forms.Label();
            this.button_get_status = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_NAM = new System.Windows.Forms.Button();
            this.button_WAM = new System.Windows.Forms.Button();
            this.button_SFM = new System.Windows.Forms.Button();
            this.button_CW = new System.Windows.Forms.Button();
            this.button_LSB = new System.Windows.Forms.Button();
            this.button_USB = new System.Windows.Forms.Button();
            this.button_AM = new System.Windows.Forms.Button();
            this.button_NFM = new System.Windows.Forms.Button();
            this.button_WFM = new System.Windows.Forms.Button();
            this.button_set_frequency = new System.Windows.Forms.Button();
            this.comboBox_step = new System.Windows.Forms.ComboBox();
            this.button_AT_on = new System.Windows.Forms.Button();
            this.button_AT_off = new System.Windows.Forms.Button();
            this.button_freq_level = new System.Windows.Forms.Button();
            this.label_seconds = new System.Windows.Forms.Label();
            this.label_Level_max = new System.Windows.Forms.Label();
            this.label_Level_curr = new System.Windows.Forms.Label();
            this.label_Level_min = new System.Windows.Forms.Label();
            this.label_Level_maximum = new System.Windows.Forms.Label();
            this.label_Level_current = new System.Windows.Forms.Label();
            this.label_Level_minimum = new System.Windows.Forms.Label();
            this.groupBox_modulation = new System.Windows.Forms.GroupBox();
            this.radioButton_NAM = new System.Windows.Forms.RadioButton();
            this.radioButton_WAM = new System.Windows.Forms.RadioButton();
            this.radioButton_CW = new System.Windows.Forms.RadioButton();
            this.radioButton_LSB = new System.Windows.Forms.RadioButton();
            this.radioButton_SFM = new System.Windows.Forms.RadioButton();
            this.radioButton_AM = new System.Windows.Forms.RadioButton();
            this.radioButton_USB = new System.Windows.Forms.RadioButton();
            this.radioButton_NFM = new System.Windows.Forms.RadioButton();
            this.radioButton_WFM = new System.Windows.Forms.RadioButton();
            this.textBox_scanner_answer = new System.Windows.Forms.TextBox();
            this.button_scan = new System.Windows.Forms.Button();
            this.button_save_frequency = new System.Windows.Forms.Button();
            this.label_label_name_list = new System.Windows.Forms.Label();
            this.label_list_freq_name = new System.Windows.Forms.Label();
            this.button_change_freq_list = new System.Windows.Forms.Button();
            this.groupBox_Level = new System.Windows.Forms.GroupBox();
            this.groupBox_manual_control = new System.Windows.Forms.GroupBox();
            this.label_step = new System.Windows.Forms.Label();
            this.groupBox_sound_recording = new System.Windows.Forms.GroupBox();
            this.groupBox_frequency = new System.Windows.Forms.GroupBox();
            this.checkBox_ATT = new System.Windows.Forms.CheckBox();
            this.label_mhz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_List_frequency = new System.Windows.Forms.GroupBox();
            this.groupBox_list = new System.Windows.Forms.GroupBox();
            this.button_scan_stop = new System.Windows.Forms.Button();
            this.progressBar_s_meter = new ar8600.VerticalProgressBar();
            this.groupBox_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox_modulation.SuspendLayout();
            this.groupBox_Level.SuspendLayout();
            this.groupBox_manual_control.SuspendLayout();
            this.groupBox_sound_recording.SuspendLayout();
            this.groupBox_frequency.SuspendLayout();
            this.groupBox_List_frequency.SuspendLayout();
            this.groupBox_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_set_rs232
            // 
            this.button_set_rs232.Location = new System.Drawing.Point(215, 65);
            this.button_set_rs232.Name = "button_set_rs232";
            this.button_set_rs232.Size = new System.Drawing.Size(75, 23);
            this.button_set_rs232.TabIndex = 0;
            this.button_set_rs232.Text = "Настроить";
            this.toolTip1.SetToolTip(this.button_set_rs232, "Задать параметры RS232");
            this.button_set_rs232.UseVisualStyleBackColor = true;
            this.button_set_rs232.Click += new System.EventHandler(this.button_set_rs232_Click);
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_settings.Controls.Add(this.label_check_settings);
            this.groupBox_settings.Controls.Add(this.label_set_parameters);
            this.groupBox_settings.Controls.Add(this.button_set_rs232);
            this.groupBox_settings.Location = new System.Drawing.Point(12, 6);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(339, 112);
            this.groupBox_settings.TabIndex = 2;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Настройки соединения";
            // 
            // label_check_settings
            // 
            this.label_check_settings.AutoSize = true;
            this.label_check_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_check_settings.Location = new System.Drawing.Point(15, 38);
            this.label_check_settings.Name = "label_check_settings";
            this.label_check_settings.Size = new System.Drawing.Size(0, 13);
            this.label_check_settings.TabIndex = 2;
            // 
            // label_set_parameters
            // 
            this.label_set_parameters.AutoSize = true;
            this.label_set_parameters.Location = new System.Drawing.Point(15, 70);
            this.label_set_parameters.Name = "label_set_parameters";
            this.label_set_parameters.Size = new System.Drawing.Size(184, 13);
            this.label_set_parameters.TabIndex = 1;
            this.label_set_parameters.Text = "Настроить подключение СОМ порт";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Внешний вид сканера AR8600");
            // 
            // numericUpDown
            // 
            this.numericUpDown.DecimalPlaces = 5;
            this.numericUpDown.Increment = new decimal(new int[] {
            125,
            0,
            0,
            262144});
            this.numericUpDown.Location = new System.Drawing.Point(104, 19);
            this.numericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.numericUpDown, "Частота сигнала. Пятый знак после запятой должен быть или \"0\" или \"5\". Это будет " +
        "означать, частота заканчивается на 0 или 50 Гц.");
            this.numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_KeyDown);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(6, 25);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(94, 59);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Подключиться";
            this.toolTip1.SetToolTip(this.button_connect, "Попытаться соединиться со сканером");
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_turn_off
            // 
            this.button_turn_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_turn_off.Location = new System.Drawing.Point(402, 165);
            this.button_turn_off.Name = "button_turn_off";
            this.button_turn_off.Size = new System.Drawing.Size(103, 23);
            this.button_turn_off.TabIndex = 2;
            this.button_turn_off.Text = "Выкл сканер";
            this.toolTip1.SetToolTip(this.button_turn_off, "Отправить команду сканеру \"Отключить питание\"");
            this.button_turn_off.UseVisualStyleBackColor = true;
            this.button_turn_off.Click += new System.EventHandler(this.button_turn_off_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_disconnect.Location = new System.Drawing.Point(402, 195);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(103, 23);
            this.button_disconnect.TabIndex = 3;
            this.button_disconnect.Text = "Отключиться";
            this.toolTip1.SetToolTip(this.button_disconnect, "Закрыть соединение через СОМ порт");
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_start_rec
            // 
            this.button_start_rec.Location = new System.Drawing.Point(6, 21);
            this.button_start_rec.Name = "button_start_rec";
            this.button_start_rec.Size = new System.Drawing.Size(54, 45);
            this.button_start_rec.TabIndex = 0;
            this.button_start_rec.Text = "REC";
            this.toolTip1.SetToolTip(this.button_start_rec, "Начать запись звука");
            this.button_start_rec.UseVisualStyleBackColor = true;
            this.button_start_rec.Click += new System.EventHandler(this.button_start_rec_Click);
            // 
            // button_stop_rec
            // 
            this.button_stop_rec.Enabled = false;
            this.button_stop_rec.Location = new System.Drawing.Point(149, 19);
            this.button_stop_rec.Name = "button_stop_rec";
            this.button_stop_rec.Size = new System.Drawing.Size(55, 46);
            this.button_stop_rec.TabIndex = 1;
            this.button_stop_rec.Text = "STOP";
            this.toolTip1.SetToolTip(this.button_stop_rec, "Остановить звукозапись");
            this.button_stop_rec.UseVisualStyleBackColor = true;
            this.button_stop_rec.Click += new System.EventHandler(this.button_stop_rec_Click);
            // 
            // label_rec
            // 
            this.label_rec.AutoSize = true;
            this.label_rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rec.ForeColor = System.Drawing.Color.Red;
            this.label_rec.Location = new System.Drawing.Point(65, 26);
            this.label_rec.Name = "label_rec";
            this.label_rec.Size = new System.Drawing.Size(0, 13);
            this.label_rec.TabIndex = 2;
            this.toolTip1.SetToolTip(this.label_rec, "Сейчас происходит запись звука в аудиофайл");
            // 
            // button_get_status
            // 
            this.button_get_status.Location = new System.Drawing.Point(343, 480);
            this.button_get_status.Name = "button_get_status";
            this.button_get_status.Size = new System.Drawing.Size(63, 56);
            this.button_get_status.TabIndex = 6;
            this.button_get_status.Text = "Получить текущие данные";
            this.toolTip1.SetToolTip(this.button_get_status, "Сканер вернёт текущие данные");
            this.button_get_status.UseVisualStyleBackColor = true;
            this.button_get_status.Click += new System.EventHandler(this.button_get_status_Click);
            // 
            // button_right
            // 
            this.button_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_right.Location = new System.Drawing.Point(470, 95);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(34, 32);
            this.button_right.TabIndex = 7;
            this.button_right.Text = ">";
            this.toolTip1.SetToolTip(this.button_right, "Нажать на сканере кнопку со стрелкой вправо");
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_left.Location = new System.Drawing.Point(402, 95);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(35, 32);
            this.button_left.TabIndex = 7;
            this.button_left.Text = "<";
            this.toolTip1.SetToolTip(this.button_left, "Нажать на сканере кнопку со стрелкой влево");
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_up
            // 
            this.button_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_up.Location = new System.Drawing.Point(436, 64);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(35, 31);
            this.button_up.TabIndex = 7;
            this.button_up.Text = "UP";
            this.toolTip1.SetToolTip(this.button_up, "Нажать на сканере кнопку со стрелкой вверх");
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // button_down
            // 
            this.button_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_down.Location = new System.Drawing.Point(436, 127);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(35, 31);
            this.button_down.TabIndex = 7;
            this.button_down.Text = "DN";
            this.toolTip1.SetToolTip(this.button_down, "Нажать на сканере кнопку со стрелкой вниз");
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_NAM
            // 
            this.button_NAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NAM.Location = new System.Drawing.Point(349, 195);
            this.button_NAM.Name = "button_NAM";
            this.button_NAM.Size = new System.Drawing.Size(42, 23);
            this.button_NAM.TabIndex = 7;
            this.button_NAM.Text = "NAM";
            this.toolTip1.SetToolTip(this.button_NAM, "Выбрать модуляцию NAM");
            this.button_NAM.UseVisualStyleBackColor = true;
            this.button_NAM.Click += new System.EventHandler(this.button_NAM_Click);
            // 
            // button_WAM
            // 
            this.button_WAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WAM.Location = new System.Drawing.Point(349, 172);
            this.button_WAM.Name = "button_WAM";
            this.button_WAM.Size = new System.Drawing.Size(42, 23);
            this.button_WAM.TabIndex = 7;
            this.button_WAM.Text = "WAM";
            this.toolTip1.SetToolTip(this.button_WAM, "Выбрать модуляцию WAM");
            this.button_WAM.UseVisualStyleBackColor = true;
            this.button_WAM.Click += new System.EventHandler(this.button_WAM_Click);
            // 
            // button_SFM
            // 
            this.button_SFM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SFM.Location = new System.Drawing.Point(349, 149);
            this.button_SFM.Name = "button_SFM";
            this.button_SFM.Size = new System.Drawing.Size(42, 23);
            this.button_SFM.TabIndex = 7;
            this.button_SFM.Text = "SFM";
            this.toolTip1.SetToolTip(this.button_SFM, "Выбрать модуляцию SFM");
            this.button_SFM.UseVisualStyleBackColor = true;
            this.button_SFM.Click += new System.EventHandler(this.button_SFM_Click);
            // 
            // button_CW
            // 
            this.button_CW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CW.Location = new System.Drawing.Point(349, 126);
            this.button_CW.Name = "button_CW";
            this.button_CW.Size = new System.Drawing.Size(42, 23);
            this.button_CW.TabIndex = 7;
            this.button_CW.Text = "CW";
            this.toolTip1.SetToolTip(this.button_CW, "Выбрать модуляцию CW");
            this.button_CW.UseVisualStyleBackColor = true;
            this.button_CW.Click += new System.EventHandler(this.button_CW_Click);
            // 
            // button_LSB
            // 
            this.button_LSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LSB.Location = new System.Drawing.Point(349, 103);
            this.button_LSB.Name = "button_LSB";
            this.button_LSB.Size = new System.Drawing.Size(42, 23);
            this.button_LSB.TabIndex = 7;
            this.button_LSB.Text = "LSB";
            this.toolTip1.SetToolTip(this.button_LSB, "Выбрать модуляцию LSB");
            this.button_LSB.UseVisualStyleBackColor = true;
            this.button_LSB.Click += new System.EventHandler(this.button_LSB_Click);
            // 
            // button_USB
            // 
            this.button_USB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_USB.Location = new System.Drawing.Point(349, 80);
            this.button_USB.Name = "button_USB";
            this.button_USB.Size = new System.Drawing.Size(42, 23);
            this.button_USB.TabIndex = 7;
            this.button_USB.Text = "USB";
            this.toolTip1.SetToolTip(this.button_USB, "Выбрать модуляцию USB");
            this.button_USB.UseVisualStyleBackColor = true;
            this.button_USB.Click += new System.EventHandler(this.button_USB_Click);
            // 
            // button_AM
            // 
            this.button_AM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AM.Location = new System.Drawing.Point(349, 57);
            this.button_AM.Name = "button_AM";
            this.button_AM.Size = new System.Drawing.Size(42, 23);
            this.button_AM.TabIndex = 7;
            this.button_AM.Text = "AM";
            this.toolTip1.SetToolTip(this.button_AM, "Выбрать модуляцию AM");
            this.button_AM.UseVisualStyleBackColor = true;
            this.button_AM.Click += new System.EventHandler(this.button_AM_Click);
            // 
            // button_NFM
            // 
            this.button_NFM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NFM.Location = new System.Drawing.Point(349, 34);
            this.button_NFM.Name = "button_NFM";
            this.button_NFM.Size = new System.Drawing.Size(42, 23);
            this.button_NFM.TabIndex = 7;
            this.button_NFM.Text = "NFM";
            this.toolTip1.SetToolTip(this.button_NFM, "Выбрать модуляцию NFM");
            this.button_NFM.UseVisualStyleBackColor = true;
            this.button_NFM.Click += new System.EventHandler(this.button_NFM_Click);
            // 
            // button_WFM
            // 
            this.button_WFM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WFM.Location = new System.Drawing.Point(349, 11);
            this.button_WFM.Name = "button_WFM";
            this.button_WFM.Size = new System.Drawing.Size(42, 23);
            this.button_WFM.TabIndex = 7;
            this.button_WFM.Text = "WFM";
            this.toolTip1.SetToolTip(this.button_WFM, "Выбрать модуляцию WFM");
            this.button_WFM.UseVisualStyleBackColor = true;
            this.button_WFM.Click += new System.EventHandler(this.button_WFM_Click);
            // 
            // button_set_frequency
            // 
            this.button_set_frequency.Location = new System.Drawing.Point(250, 81);
            this.button_set_frequency.Name = "button_set_frequency";
            this.button_set_frequency.Size = new System.Drawing.Size(83, 40);
            this.button_set_frequency.TabIndex = 1;
            this.button_set_frequency.Text = "Настроиться";
            this.toolTip1.SetToolTip(this.button_set_frequency, "Отправить сканеру команду настроиться на частоту. Встать на канал.");
            this.button_set_frequency.UseVisualStyleBackColor = true;
            this.button_set_frequency.Click += new System.EventHandler(this.button_set_frequency_Click);
            // 
            // comboBox_step
            // 
            this.comboBox_step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_step.FormattingEnabled = true;
            this.comboBox_step.Location = new System.Drawing.Point(456, 13);
            this.comboBox_step.Name = "comboBox_step";
            this.comboBox_step.Size = new System.Drawing.Size(49, 21);
            this.comboBox_step.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBox_step, "Шаг подстройки частоты");
            this.comboBox_step.SelectedIndexChanged += new System.EventHandler(this.comboBox_step_SelectedIndexChanged);
            // 
            // button_AT_on
            // 
            this.button_AT_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AT_on.Location = new System.Drawing.Point(402, 37);
            this.button_AT_on.Name = "button_AT_on";
            this.button_AT_on.Size = new System.Drawing.Size(52, 23);
            this.button_AT_on.TabIndex = 9;
            this.button_AT_on.Text = "AT ON";
            this.toolTip1.SetToolTip(this.button_AT_on, "Включить аттенюатор");
            this.button_AT_on.UseVisualStyleBackColor = true;
            this.button_AT_on.Click += new System.EventHandler(this.button_AT_on_Click);
            // 
            // button_AT_off
            // 
            this.button_AT_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AT_off.Location = new System.Drawing.Point(456, 37);
            this.button_AT_off.Name = "button_AT_off";
            this.button_AT_off.Size = new System.Drawing.Size(52, 23);
            this.button_AT_off.TabIndex = 9;
            this.button_AT_off.Text = "AT OFF";
            this.toolTip1.SetToolTip(this.button_AT_off, "Отключить аттенюатор");
            this.button_AT_off.UseVisualStyleBackColor = true;
            this.button_AT_off.Click += new System.EventHandler(this.button_AT_off_Click);
            // 
            // button_freq_level
            // 
            this.button_freq_level.Location = new System.Drawing.Point(437, 462);
            this.button_freq_level.Name = "button_freq_level";
            this.button_freq_level.Size = new System.Drawing.Size(89, 74);
            this.button_freq_level.TabIndex = 8;
            this.button_freq_level.Text = "Возвращать частоту и уровень";
            this.toolTip1.SetToolTip(this.button_freq_level, "Для режима сканирования");
            this.button_freq_level.UseVisualStyleBackColor = true;
            this.button_freq_level.Click += new System.EventHandler(this.button_freq_level_Click);
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_seconds.ForeColor = System.Drawing.Color.Red;
            this.label_seconds.Location = new System.Drawing.Point(67, 50);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(0, 13);
            this.label_seconds.TabIndex = 3;
            this.toolTip1.SetToolTip(this.label_seconds, "Секунд записано");
            // 
            // label_Level_max
            // 
            this.label_Level_max.AutoSize = true;
            this.label_Level_max.Location = new System.Drawing.Point(6, 15);
            this.label_Level_max.Name = "label_Level_max";
            this.label_Level_max.Size = new System.Drawing.Size(30, 13);
            this.label_Level_max.TabIndex = 12;
            this.label_Level_max.Text = "Max:";
            this.toolTip1.SetToolTip(this.label_Level_max, "Максимально возможное значение S метра");
            // 
            // label_Level_curr
            // 
            this.label_Level_curr.AutoSize = true;
            this.label_Level_curr.Location = new System.Drawing.Point(6, 30);
            this.label_Level_curr.Name = "label_Level_curr";
            this.label_Level_curr.Size = new System.Drawing.Size(26, 13);
            this.label_Level_curr.TabIndex = 12;
            this.label_Level_curr.Text = "Cur:";
            this.toolTip1.SetToolTip(this.label_Level_curr, "Последнее считанное значение S метра");
            // 
            // label_Level_min
            // 
            this.label_Level_min.AutoSize = true;
            this.label_Level_min.Location = new System.Drawing.Point(6, 45);
            this.label_Level_min.Name = "label_Level_min";
            this.label_Level_min.Size = new System.Drawing.Size(27, 13);
            this.label_Level_min.TabIndex = 12;
            this.label_Level_min.Text = "Min:";
            this.toolTip1.SetToolTip(this.label_Level_min, "Минимально возможное значение S метра");
            // 
            // label_Level_maximum
            // 
            this.label_Level_maximum.AutoSize = true;
            this.label_Level_maximum.Location = new System.Drawing.Point(40, 15);
            this.label_Level_maximum.Name = "label_Level_maximum";
            this.label_Level_maximum.Size = new System.Drawing.Size(25, 13);
            this.label_Level_maximum.TabIndex = 12;
            this.label_Level_maximum.Text = "255";
            this.toolTip1.SetToolTip(this.label_Level_maximum, "Максимально возможное значение S метра");
            // 
            // label_Level_current
            // 
            this.label_Level_current.AutoSize = true;
            this.label_Level_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Level_current.Location = new System.Drawing.Point(38, 30);
            this.label_Level_current.Name = "label_Level_current";
            this.label_Level_current.Size = new System.Drawing.Size(0, 13);
            this.label_Level_current.TabIndex = 12;
            this.toolTip1.SetToolTip(this.label_Level_current, "Последнее считанное значение S метра");
            // 
            // label_Level_minimum
            // 
            this.label_Level_minimum.AutoSize = true;
            this.label_Level_minimum.Location = new System.Drawing.Point(52, 45);
            this.label_Level_minimum.Name = "label_Level_minimum";
            this.label_Level_minimum.Size = new System.Drawing.Size(13, 13);
            this.label_Level_minimum.TabIndex = 12;
            this.label_Level_minimum.Text = "0";
            this.toolTip1.SetToolTip(this.label_Level_minimum, "Минимально возможное значение S метра");
            // 
            // groupBox_modulation
            // 
            this.groupBox_modulation.Controls.Add(this.radioButton_NAM);
            this.groupBox_modulation.Controls.Add(this.radioButton_WAM);
            this.groupBox_modulation.Controls.Add(this.radioButton_CW);
            this.groupBox_modulation.Controls.Add(this.radioButton_LSB);
            this.groupBox_modulation.Controls.Add(this.radioButton_SFM);
            this.groupBox_modulation.Controls.Add(this.radioButton_AM);
            this.groupBox_modulation.Controls.Add(this.radioButton_USB);
            this.groupBox_modulation.Controls.Add(this.radioButton_NFM);
            this.groupBox_modulation.Controls.Add(this.radioButton_WFM);
            this.groupBox_modulation.Location = new System.Drawing.Point(6, 39);
            this.groupBox_modulation.Name = "groupBox_modulation";
            this.groupBox_modulation.Size = new System.Drawing.Size(238, 82);
            this.groupBox_modulation.TabIndex = 3;
            this.groupBox_modulation.TabStop = false;
            this.groupBox_modulation.Text = "Модуляция";
            this.toolTip1.SetToolTip(this.groupBox_modulation, "Выбор модуляции. Для применения нажмите кнопку \"Настроиться\"");
            // 
            // radioButton_NAM
            // 
            this.radioButton_NAM.AutoSize = true;
            this.radioButton_NAM.Location = new System.Drawing.Point(166, 59);
            this.radioButton_NAM.Name = "radioButton_NAM";
            this.radioButton_NAM.Size = new System.Drawing.Size(49, 17);
            this.radioButton_NAM.TabIndex = 0;
            this.radioButton_NAM.TabStop = true;
            this.radioButton_NAM.Text = "NAM";
            this.radioButton_NAM.UseVisualStyleBackColor = true;
            // 
            // radioButton_WAM
            // 
            this.radioButton_WAM.AutoSize = true;
            this.radioButton_WAM.Location = new System.Drawing.Point(166, 40);
            this.radioButton_WAM.Name = "radioButton_WAM";
            this.radioButton_WAM.Size = new System.Drawing.Size(52, 17);
            this.radioButton_WAM.TabIndex = 0;
            this.radioButton_WAM.TabStop = true;
            this.radioButton_WAM.Text = "WAM";
            this.radioButton_WAM.UseVisualStyleBackColor = true;
            // 
            // radioButton_CW
            // 
            this.radioButton_CW.AutoSize = true;
            this.radioButton_CW.Location = new System.Drawing.Point(87, 59);
            this.radioButton_CW.Name = "radioButton_CW";
            this.radioButton_CW.Size = new System.Drawing.Size(43, 17);
            this.radioButton_CW.TabIndex = 0;
            this.radioButton_CW.TabStop = true;
            this.radioButton_CW.Text = "CW";
            this.radioButton_CW.UseVisualStyleBackColor = true;
            // 
            // radioButton_LSB
            // 
            this.radioButton_LSB.AutoSize = true;
            this.radioButton_LSB.Location = new System.Drawing.Point(87, 40);
            this.radioButton_LSB.Name = "radioButton_LSB";
            this.radioButton_LSB.Size = new System.Drawing.Size(45, 17);
            this.radioButton_LSB.TabIndex = 0;
            this.radioButton_LSB.TabStop = true;
            this.radioButton_LSB.Text = "LSB";
            this.radioButton_LSB.UseVisualStyleBackColor = true;
            // 
            // radioButton_SFM
            // 
            this.radioButton_SFM.AutoSize = true;
            this.radioButton_SFM.Location = new System.Drawing.Point(166, 21);
            this.radioButton_SFM.Name = "radioButton_SFM";
            this.radioButton_SFM.Size = new System.Drawing.Size(47, 17);
            this.radioButton_SFM.TabIndex = 0;
            this.radioButton_SFM.TabStop = true;
            this.radioButton_SFM.Text = "SFM";
            this.radioButton_SFM.UseVisualStyleBackColor = true;
            // 
            // radioButton_AM
            // 
            this.radioButton_AM.AutoSize = true;
            this.radioButton_AM.Location = new System.Drawing.Point(6, 59);
            this.radioButton_AM.Name = "radioButton_AM";
            this.radioButton_AM.Size = new System.Drawing.Size(41, 17);
            this.radioButton_AM.TabIndex = 0;
            this.radioButton_AM.TabStop = true;
            this.radioButton_AM.Text = "AM";
            this.radioButton_AM.UseVisualStyleBackColor = true;
            // 
            // radioButton_USB
            // 
            this.radioButton_USB.AutoSize = true;
            this.radioButton_USB.Location = new System.Drawing.Point(87, 21);
            this.radioButton_USB.Name = "radioButton_USB";
            this.radioButton_USB.Size = new System.Drawing.Size(47, 17);
            this.radioButton_USB.TabIndex = 0;
            this.radioButton_USB.TabStop = true;
            this.radioButton_USB.Text = "USB";
            this.radioButton_USB.UseVisualStyleBackColor = true;
            // 
            // radioButton_NFM
            // 
            this.radioButton_NFM.AutoSize = true;
            this.radioButton_NFM.Location = new System.Drawing.Point(6, 40);
            this.radioButton_NFM.Name = "radioButton_NFM";
            this.radioButton_NFM.Size = new System.Drawing.Size(48, 17);
            this.radioButton_NFM.TabIndex = 0;
            this.radioButton_NFM.TabStop = true;
            this.radioButton_NFM.Text = "NFM";
            this.radioButton_NFM.UseVisualStyleBackColor = true;
            // 
            // radioButton_WFM
            // 
            this.radioButton_WFM.AutoSize = true;
            this.radioButton_WFM.Location = new System.Drawing.Point(6, 21);
            this.radioButton_WFM.Name = "radioButton_WFM";
            this.radioButton_WFM.Size = new System.Drawing.Size(51, 17);
            this.radioButton_WFM.TabIndex = 0;
            this.radioButton_WFM.TabStop = true;
            this.radioButton_WFM.Text = "WFM";
            this.radioButton_WFM.UseVisualStyleBackColor = true;
            // 
            // textBox_scanner_answer
            // 
            this.textBox_scanner_answer.Location = new System.Drawing.Point(12, 516);
            this.textBox_scanner_answer.Name = "textBox_scanner_answer";
            this.textBox_scanner_answer.Size = new System.Drawing.Size(325, 20);
            this.textBox_scanner_answer.TabIndex = 7;
            this.textBox_scanner_answer.Text = "Крайний ответ сканера";
            this.toolTip1.SetToolTip(this.textBox_scanner_answer, "Ответ сканера на команды программы");
            // 
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(256, 13);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(83, 29);
            this.button_scan.TabIndex = 10;
            this.button_scan.Text = "Старт";
            this.toolTip1.SetToolTip(this.button_scan, "Начать сканирование списка частот со звукозаписью, если обнаружена активность");
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // button_save_frequency
            // 
            this.button_save_frequency.Location = new System.Drawing.Point(6, 25);
            this.button_save_frequency.Name = "button_save_frequency";
            this.button_save_frequency.Size = new System.Drawing.Size(75, 48);
            this.button_save_frequency.TabIndex = 9;
            this.button_save_frequency.Text = "Добавить частоту в файл";
            this.toolTip1.SetToolTip(this.button_save_frequency, "Вызвать окно добавления частоты в файл");
            this.button_save_frequency.UseVisualStyleBackColor = true;
            this.button_save_frequency.Click += new System.EventHandler(this.button_save_frequency_Click);
            // 
            // label_label_name_list
            // 
            this.label_label_name_list.AutoSize = true;
            this.label_label_name_list.Location = new System.Drawing.Point(3, 9);
            this.label_label_name_list.Name = "label_label_name_list";
            this.label_label_name_list.Size = new System.Drawing.Size(49, 13);
            this.label_label_name_list.TabIndex = 11;
            this.label_label_name_list.Text = "Выбран:";
            this.toolTip1.SetToolTip(this.label_label_name_list, "Выбранный список частот");
            // 
            // label_list_freq_name
            // 
            this.label_list_freq_name.AutoSize = true;
            this.label_list_freq_name.Location = new System.Drawing.Point(50, 9);
            this.label_list_freq_name.Name = "label_list_freq_name";
            this.label_list_freq_name.Size = new System.Drawing.Size(62, 13);
            this.label_list_freq_name.TabIndex = 12;
            this.label_list_freq_name.Text = "scan_list.txt";
            this.toolTip1.SetToolTip(this.label_list_freq_name, "Название выбранного файла со списком частот");
            // 
            // button_change_freq_list
            // 
            this.button_change_freq_list.Location = new System.Drawing.Point(36, 25);
            this.button_change_freq_list.Name = "button_change_freq_list";
            this.button_change_freq_list.Size = new System.Drawing.Size(75, 23);
            this.button_change_freq_list.TabIndex = 13;
            this.button_change_freq_list.Text = "Изменить";
            this.toolTip1.SetToolTip(this.button_change_freq_list, "Выбрать другой список частот");
            this.button_change_freq_list.UseVisualStyleBackColor = true;
            this.button_change_freq_list.Click += new System.EventHandler(this.button_change_freq_list_Click);
            // 
            // groupBox_Level
            // 
            this.groupBox_Level.Controls.Add(this.label_Level_minimum);
            this.groupBox_Level.Controls.Add(this.label_Level_current);
            this.groupBox_Level.Controls.Add(this.label_Level_min);
            this.groupBox_Level.Controls.Add(this.label_Level_maximum);
            this.groupBox_Level.Controls.Add(this.label_Level_curr);
            this.groupBox_Level.Controls.Add(this.label_Level_max);
            this.groupBox_Level.Controls.Add(this.progressBar_s_meter);
            this.groupBox_Level.Location = new System.Drawing.Point(249, 12);
            this.groupBox_Level.Name = "groupBox_Level";
            this.groupBox_Level.Size = new System.Drawing.Size(84, 63);
            this.groupBox_Level.TabIndex = 5;
            this.groupBox_Level.TabStop = false;
            this.groupBox_Level.Text = "Уровень";
            // 
            // groupBox_manual_control
            // 
            this.groupBox_manual_control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_manual_control.Controls.Add(this.button_AT_off);
            this.groupBox_manual_control.Controls.Add(this.button_AT_on);
            this.groupBox_manual_control.Controls.Add(this.label_step);
            this.groupBox_manual_control.Controls.Add(this.comboBox_step);
            this.groupBox_manual_control.Controls.Add(this.button_WFM);
            this.groupBox_manual_control.Controls.Add(this.button_NFM);
            this.groupBox_manual_control.Controls.Add(this.button_AM);
            this.groupBox_manual_control.Controls.Add(this.button_USB);
            this.groupBox_manual_control.Controls.Add(this.button_LSB);
            this.groupBox_manual_control.Controls.Add(this.button_CW);
            this.groupBox_manual_control.Controls.Add(this.button_SFM);
            this.groupBox_manual_control.Controls.Add(this.button_WAM);
            this.groupBox_manual_control.Controls.Add(this.button_NAM);
            this.groupBox_manual_control.Controls.Add(this.button_down);
            this.groupBox_manual_control.Controls.Add(this.groupBox_sound_recording);
            this.groupBox_manual_control.Controls.Add(this.groupBox_frequency);
            this.groupBox_manual_control.Controls.Add(this.button_up);
            this.groupBox_manual_control.Controls.Add(this.button_disconnect);
            this.groupBox_manual_control.Controls.Add(this.button_turn_off);
            this.groupBox_manual_control.Controls.Add(this.button_left);
            this.groupBox_manual_control.Controls.Add(this.button_connect);
            this.groupBox_manual_control.Controls.Add(this.button_right);
            this.groupBox_manual_control.Location = new System.Drawing.Point(12, 134);
            this.groupBox_manual_control.Name = "groupBox_manual_control";
            this.groupBox_manual_control.Size = new System.Drawing.Size(514, 224);
            this.groupBox_manual_control.TabIndex = 4;
            this.groupBox_manual_control.TabStop = false;
            this.groupBox_manual_control.Text = "Ручное (пошаговое) управление";
            // 
            // label_step
            // 
            this.label_step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_step.AutoSize = true;
            this.label_step.Location = new System.Drawing.Point(402, 16);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(48, 13);
            this.label_step.TabIndex = 8;
            this.label_step.Text = "Шаг кГц";
            // 
            // groupBox_sound_recording
            // 
            this.groupBox_sound_recording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_sound_recording.Controls.Add(this.label_seconds);
            this.groupBox_sound_recording.Controls.Add(this.label_rec);
            this.groupBox_sound_recording.Controls.Add(this.button_stop_rec);
            this.groupBox_sound_recording.Controls.Add(this.button_start_rec);
            this.groupBox_sound_recording.Location = new System.Drawing.Point(134, 19);
            this.groupBox_sound_recording.Name = "groupBox_sound_recording";
            this.groupBox_sound_recording.Size = new System.Drawing.Size(210, 71);
            this.groupBox_sound_recording.TabIndex = 5;
            this.groupBox_sound_recording.TabStop = false;
            this.groupBox_sound_recording.Text = "Запись звука";
            // 
            // groupBox_frequency
            // 
            this.groupBox_frequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_frequency.Controls.Add(this.groupBox_Level);
            this.groupBox_frequency.Controls.Add(this.checkBox_ATT);
            this.groupBox_frequency.Controls.Add(this.groupBox_modulation);
            this.groupBox_frequency.Controls.Add(this.label_mhz);
            this.groupBox_frequency.Controls.Add(this.button_set_frequency);
            this.groupBox_frequency.Controls.Add(this.numericUpDown);
            this.groupBox_frequency.Location = new System.Drawing.Point(6, 91);
            this.groupBox_frequency.Name = "groupBox_frequency";
            this.groupBox_frequency.Size = new System.Drawing.Size(338, 127);
            this.groupBox_frequency.TabIndex = 4;
            this.groupBox_frequency.TabStop = false;
            this.groupBox_frequency.Text = "Частота/канал";
            // 
            // checkBox_ATT
            // 
            this.checkBox_ATT.AutoSize = true;
            this.checkBox_ATT.Location = new System.Drawing.Point(12, 20);
            this.checkBox_ATT.Name = "checkBox_ATT";
            this.checkBox_ATT.Size = new System.Drawing.Size(86, 17);
            this.checkBox_ATT.TabIndex = 4;
            this.checkBox_ATT.Text = "Аттенюатор";
            this.checkBox_ATT.UseVisualStyleBackColor = true;
            // 
            // label_mhz
            // 
            this.label_mhz.AutoSize = true;
            this.label_mhz.Location = new System.Drawing.Point(195, 23);
            this.label_mhz.Name = "label_mhz";
            this.label_mhz.Size = new System.Drawing.Size(28, 13);
            this.label_mhz.TabIndex = 2;
            this.label_mhz.Text = "МГц";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_List_frequency
            // 
            this.groupBox_List_frequency.Controls.Add(this.button_scan_stop);
            this.groupBox_List_frequency.Controls.Add(this.groupBox_list);
            this.groupBox_List_frequency.Controls.Add(this.button_save_frequency);
            this.groupBox_List_frequency.Controls.Add(this.button_scan);
            this.groupBox_List_frequency.Location = new System.Drawing.Point(12, 364);
            this.groupBox_List_frequency.Name = "groupBox_List_frequency";
            this.groupBox_List_frequency.Size = new System.Drawing.Size(344, 84);
            this.groupBox_List_frequency.TabIndex = 11;
            this.groupBox_List_frequency.TabStop = false;
            this.groupBox_List_frequency.Text = "Работа со списком частот";
            // 
            // groupBox_list
            // 
            this.groupBox_list.Controls.Add(this.button_change_freq_list);
            this.groupBox_list.Controls.Add(this.label_label_name_list);
            this.groupBox_list.Controls.Add(this.label_list_freq_name);
            this.groupBox_list.Location = new System.Drawing.Point(99, 20);
            this.groupBox_list.Name = "groupBox_list";
            this.groupBox_list.Size = new System.Drawing.Size(141, 53);
            this.groupBox_list.TabIndex = 14;
            this.groupBox_list.TabStop = false;
            // 
            // button_scan_stop
            // 
            this.button_scan_stop.Location = new System.Drawing.Point(256, 49);
            this.button_scan_stop.Name = "button_scan_stop";
            this.button_scan_stop.Size = new System.Drawing.Size(83, 29);
            this.button_scan_stop.TabIndex = 6;
            this.button_scan_stop.Text = "Стоп";
            this.toolTip1.SetToolTip(this.button_scan_stop, "Прекратить сканирование");
            this.button_scan_stop.UseVisualStyleBackColor = true;
            this.button_scan_stop.Click += new System.EventHandler(this.button_scan_stop_Click);
            // 
            // progressBar_s_meter
            // 
            this.progressBar_s_meter.Location = new System.Drawing.Point(68, 10);
            this.progressBar_s_meter.MarqueeAnimationSpeed = 1;
            this.progressBar_s_meter.Maximum = 255;
            this.progressBar_s_meter.Name = "progressBar_s_meter";
            this.progressBar_s_meter.Size = new System.Drawing.Size(10, 48);
            this.progressBar_s_meter.Step = 1;
            this.progressBar_s_meter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_s_meter.TabIndex = 11;
            this.toolTip1.SetToolTip(this.progressBar_s_meter, "Полученный уровень сигнала от 0 до 255. S-meter.");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(538, 548);
            this.Controls.Add(this.groupBox_List_frequency);
            this.Controls.Add(this.button_freq_level);
            this.Controls.Add(this.textBox_scanner_answer);
            this.Controls.Add(this.button_get_status);
            this.Controls.Add(this.groupBox_manual_control);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(554, 489);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AR8600 управление";
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox_modulation.ResumeLayout(false);
            this.groupBox_modulation.PerformLayout();
            this.groupBox_Level.ResumeLayout(false);
            this.groupBox_Level.PerformLayout();
            this.groupBox_manual_control.ResumeLayout(false);
            this.groupBox_manual_control.PerformLayout();
            this.groupBox_sound_recording.ResumeLayout(false);
            this.groupBox_sound_recording.PerformLayout();
            this.groupBox_frequency.ResumeLayout(false);
            this.groupBox_frequency.PerformLayout();
            this.groupBox_List_frequency.ResumeLayout(false);
            this.groupBox_list.ResumeLayout(false);
            this.groupBox_list.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_set_rs232;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_set_parameters;
        private System.Windows.Forms.Label label_check_settings;
        private System.Windows.Forms.GroupBox groupBox_manual_control;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_turn_off;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.GroupBox groupBox_frequency;
        private System.Windows.Forms.GroupBox groupBox_sound_recording;
        private System.Windows.Forms.Button button_stop_rec;
        private System.Windows.Forms.Button button_start_rec;
        private System.Windows.Forms.Label label_rec;
        private System.Windows.Forms.Button button_get_status;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_NAM;
        private System.Windows.Forms.Button button_WFM;
        private System.Windows.Forms.Button button_NFM;
        private System.Windows.Forms.Button button_AM;
        private System.Windows.Forms.Button button_USB;
        private System.Windows.Forms.Button button_LSB;
        private System.Windows.Forms.Button button_CW;
        private System.Windows.Forms.Button button_SFM;
        private System.Windows.Forms.Button button_WAM;
        private System.Windows.Forms.TextBox textBox_scanner_answer;
        private System.Windows.Forms.Button button_set_frequency;
        private System.Windows.Forms.ComboBox comboBox_step;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.Label label_mhz;
        private System.Windows.Forms.GroupBox groupBox_modulation;
        private System.Windows.Forms.RadioButton radioButton_NAM;
        private System.Windows.Forms.RadioButton radioButton_WAM;
        private System.Windows.Forms.RadioButton radioButton_CW;
        private System.Windows.Forms.RadioButton radioButton_LSB;
        private System.Windows.Forms.RadioButton radioButton_SFM;
        private System.Windows.Forms.RadioButton radioButton_AM;
        private System.Windows.Forms.RadioButton radioButton_USB;
        private System.Windows.Forms.RadioButton radioButton_NFM;
        private System.Windows.Forms.RadioButton radioButton_WFM;
        private System.Windows.Forms.Button button_AT_off;
        private System.Windows.Forms.Button button_AT_on;
        private System.Windows.Forms.CheckBox checkBox_ATT;
        private System.Windows.Forms.Button button_freq_level;
        private System.Windows.Forms.Label label_seconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_Level;
        private VerticalProgressBar progressBar_s_meter;
        private System.Windows.Forms.Label label_Level_minimum;
        private System.Windows.Forms.Label label_Level_current;
        private System.Windows.Forms.Label label_Level_min;
        private System.Windows.Forms.Label label_Level_maximum;
        private System.Windows.Forms.Label label_Level_curr;
        private System.Windows.Forms.Label label_Level_max;
        private System.Windows.Forms.Button button_save_frequency;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.GroupBox groupBox_List_frequency;
        private System.Windows.Forms.Button button_change_freq_list;
        private System.Windows.Forms.Label label_list_freq_name;
        private System.Windows.Forms.Label label_label_name_list;
        private System.Windows.Forms.GroupBox groupBox_list;
        private System.Windows.Forms.Button button_scan_stop;
    }
}