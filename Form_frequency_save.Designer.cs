
namespace ar8600
{
    partial class Form_frequency_save
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_frequency_save));
            this.groupBox_frequency = new System.Windows.Forms.GroupBox();
            this.groupBox_Squelch = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_Squelch = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_squelch_level = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Level = new System.Windows.Forms.GroupBox();
            this.label_200 = new System.Windows.Forms.Label();
            this.label_150 = new System.Windows.Forms.Label();
            this.label_100 = new System.Windows.Forms.Label();
            this.label_50 = new System.Windows.Forms.Label();
            this.label_Level_minimum = new System.Windows.Forms.Label();
            this.label_Level_current = new System.Windows.Forms.Label();
            this.label_Level_min = new System.Windows.Forms.Label();
            this.label_Level_maximum = new System.Windows.Forms.Label();
            this.label_Level_curr = new System.Windows.Forms.Label();
            this.label_Level_max = new System.Windows.Forms.Label();
            this.progressBar_s_meter = new ar8600.VerticalProgressBar();
            this.checkBox_ATT = new System.Windows.Forms.CheckBox();
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
            this.label_mhz = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button_add_to_base = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_frequency.SuspendLayout();
            this.groupBox_Squelch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Squelch)).BeginInit();
            this.groupBox_Level.SuspendLayout();
            this.groupBox_modulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_frequency
            // 
            this.groupBox_frequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_frequency.Controls.Add(this.groupBox_Squelch);
            this.groupBox_frequency.Controls.Add(this.groupBox_Level);
            this.groupBox_frequency.Controls.Add(this.checkBox_ATT);
            this.groupBox_frequency.Controls.Add(this.groupBox_modulation);
            this.groupBox_frequency.Controls.Add(this.label_mhz);
            this.groupBox_frequency.Controls.Add(this.numericUpDown);
            this.groupBox_frequency.Location = new System.Drawing.Point(12, 12);
            this.groupBox_frequency.Name = "groupBox_frequency";
            this.groupBox_frequency.Size = new System.Drawing.Size(466, 266);
            this.groupBox_frequency.TabIndex = 5;
            this.groupBox_frequency.TabStop = false;
            this.groupBox_frequency.Text = "Частота/канал";
            // 
            // groupBox_Squelch
            // 
            this.groupBox_Squelch.Controls.Add(this.label8);
            this.groupBox_Squelch.Controls.Add(this.label7);
            this.groupBox_Squelch.Controls.Add(this.trackBar_Squelch);
            this.groupBox_Squelch.Controls.Add(this.label6);
            this.groupBox_Squelch.Controls.Add(this.textBox_squelch_level);
            this.groupBox_Squelch.Controls.Add(this.label5);
            this.groupBox_Squelch.Controls.Add(this.label1);
            this.groupBox_Squelch.Controls.Add(this.label4);
            this.groupBox_Squelch.Controls.Add(this.label2);
            this.groupBox_Squelch.Controls.Add(this.label3);
            this.groupBox_Squelch.Location = new System.Drawing.Point(340, 12);
            this.groupBox_Squelch.Name = "groupBox_Squelch";
            this.groupBox_Squelch.Size = new System.Drawing.Size(120, 248);
            this.groupBox_Squelch.TabIndex = 9;
            this.groupBox_Squelch.TabStop = false;
            this.groupBox_Squelch.Text = "SQUELCH";
            this.toolTip1.SetToolTip(this.groupBox_Squelch, "Пороговый уровень открытия шумодава. Должен быть выше (больше), чем уровень сигна" +
        "ла на частоте без активности.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "150";
            // 
            // trackBar_Squelch
            // 
            this.trackBar_Squelch.Location = new System.Drawing.Point(66, 40);
            this.trackBar_Squelch.Maximum = 255;
            this.trackBar_Squelch.Name = "trackBar_Squelch";
            this.trackBar_Squelch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Squelch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_Squelch.RightToLeftLayout = true;
            this.trackBar_Squelch.Size = new System.Drawing.Size(45, 204);
            this.trackBar_Squelch.TabIndex = 9;
            this.trackBar_Squelch.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.trackBar_Squelch, "Отрегулируйте уровень сквелча для данной частоты");
            this.trackBar_Squelch.Scroll += new System.EventHandler(this.trackBar_Squelch_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "100";
            // 
            // textBox_squelch_level
            // 
            this.textBox_squelch_level.Location = new System.Drawing.Point(39, 18);
            this.textBox_squelch_level.Name = "textBox_squelch_level";
            this.textBox_squelch_level.Size = new System.Drawing.Size(31, 20);
            this.textBox_squelch_level.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBox_squelch_level, "Пороговый уровень открытия шумодава. Должен быть выше (больше), чем уровень сигна" +
        "ла на частоте без активности.");
            this.textBox_squelch_level.TextChanged += new System.EventHandler(this.textBox_squelch_level_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min:";
            // 
            // groupBox_Level
            // 
            this.groupBox_Level.Controls.Add(this.label_200);
            this.groupBox_Level.Controls.Add(this.label_150);
            this.groupBox_Level.Controls.Add(this.label_100);
            this.groupBox_Level.Controls.Add(this.label_50);
            this.groupBox_Level.Controls.Add(this.label_Level_minimum);
            this.groupBox_Level.Controls.Add(this.label_Level_current);
            this.groupBox_Level.Controls.Add(this.label_Level_min);
            this.groupBox_Level.Controls.Add(this.label_Level_maximum);
            this.groupBox_Level.Controls.Add(this.label_Level_curr);
            this.groupBox_Level.Controls.Add(this.label_Level_max);
            this.groupBox_Level.Controls.Add(this.progressBar_s_meter);
            this.groupBox_Level.Location = new System.Drawing.Point(249, 12);
            this.groupBox_Level.Name = "groupBox_Level";
            this.groupBox_Level.Size = new System.Drawing.Size(84, 248);
            this.groupBox_Level.TabIndex = 5;
            this.groupBox_Level.TabStop = false;
            this.groupBox_Level.Text = "Уровень";
            // 
            // label_200
            // 
            this.label_200.AutoSize = true;
            this.label_200.Location = new System.Drawing.Point(40, 82);
            this.label_200.Name = "label_200";
            this.label_200.Size = new System.Drawing.Size(25, 13);
            this.label_200.TabIndex = 12;
            this.label_200.Text = "200";
            // 
            // label_150
            // 
            this.label_150.AutoSize = true;
            this.label_150.Location = new System.Drawing.Point(40, 118);
            this.label_150.Name = "label_150";
            this.label_150.Size = new System.Drawing.Size(25, 13);
            this.label_150.TabIndex = 12;
            this.label_150.Text = "150";
            // 
            // label_100
            // 
            this.label_100.AutoSize = true;
            this.label_100.Location = new System.Drawing.Point(40, 155);
            this.label_100.Name = "label_100";
            this.label_100.Size = new System.Drawing.Size(25, 13);
            this.label_100.TabIndex = 12;
            this.label_100.Text = "100";
            // 
            // label_50
            // 
            this.label_50.AutoSize = true;
            this.label_50.Location = new System.Drawing.Point(46, 191);
            this.label_50.Name = "label_50";
            this.label_50.Size = new System.Drawing.Size(19, 13);
            this.label_50.TabIndex = 12;
            this.label_50.Text = "50";
            // 
            // label_Level_minimum
            // 
            this.label_Level_minimum.AutoSize = true;
            this.label_Level_minimum.Location = new System.Drawing.Point(52, 225);
            this.label_Level_minimum.Name = "label_Level_minimum";
            this.label_Level_minimum.Size = new System.Drawing.Size(13, 13);
            this.label_Level_minimum.TabIndex = 12;
            this.label_Level_minimum.Text = "0";
            this.toolTip1.SetToolTip(this.label_Level_minimum, "Минимальный уровень сигнала");
            // 
            // label_Level_current
            // 
            this.label_Level_current.AutoSize = true;
            this.label_Level_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Level_current.Location = new System.Drawing.Point(51, 21);
            this.label_Level_current.Name = "label_Level_current";
            this.label_Level_current.Size = new System.Drawing.Size(0, 13);
            this.label_Level_current.TabIndex = 12;
            this.toolTip1.SetToolTip(this.label_Level_current, "Текущий уровень сигнала");
            // 
            // label_Level_min
            // 
            this.label_Level_min.AutoSize = true;
            this.label_Level_min.Location = new System.Drawing.Point(6, 225);
            this.label_Level_min.Name = "label_Level_min";
            this.label_Level_min.Size = new System.Drawing.Size(27, 13);
            this.label_Level_min.TabIndex = 12;
            this.label_Level_min.Text = "Min:";
            this.toolTip1.SetToolTip(this.label_Level_min, "Минимальный уровень сигнала");
            // 
            // label_Level_maximum
            // 
            this.label_Level_maximum.AutoSize = true;
            this.label_Level_maximum.Location = new System.Drawing.Point(40, 41);
            this.label_Level_maximum.Name = "label_Level_maximum";
            this.label_Level_maximum.Size = new System.Drawing.Size(25, 13);
            this.label_Level_maximum.TabIndex = 12;
            this.label_Level_maximum.Text = "255";
            this.toolTip1.SetToolTip(this.label_Level_maximum, "Максимальный уровень сигнала");
            // 
            // label_Level_curr
            // 
            this.label_Level_curr.AutoSize = true;
            this.label_Level_curr.Location = new System.Drawing.Point(19, 21);
            this.label_Level_curr.Name = "label_Level_curr";
            this.label_Level_curr.Size = new System.Drawing.Size(26, 13);
            this.label_Level_curr.TabIndex = 12;
            this.label_Level_curr.Text = "Cur:";
            this.toolTip1.SetToolTip(this.label_Level_curr, "Текущий уровень сигнала");
            // 
            // label_Level_max
            // 
            this.label_Level_max.AutoSize = true;
            this.label_Level_max.Location = new System.Drawing.Point(6, 41);
            this.label_Level_max.Name = "label_Level_max";
            this.label_Level_max.Size = new System.Drawing.Size(30, 13);
            this.label_Level_max.TabIndex = 12;
            this.label_Level_max.Text = "Max:";
            this.toolTip1.SetToolTip(this.label_Level_max, "Максимальный уровень сигнала");
            // 
            // progressBar_s_meter
            // 
            this.progressBar_s_meter.Location = new System.Drawing.Point(68, 47);
            this.progressBar_s_meter.MarqueeAnimationSpeed = 1;
            this.progressBar_s_meter.Maximum = 255;
            this.progressBar_s_meter.Name = "progressBar_s_meter";
            this.progressBar_s_meter.Size = new System.Drawing.Size(10, 187);
            this.progressBar_s_meter.Step = 1;
            this.progressBar_s_meter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_s_meter.TabIndex = 11;
            this.toolTip1.SetToolTip(this.progressBar_s_meter, "Текущий уровень сигнала");
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
            // label_mhz
            // 
            this.label_mhz.AutoSize = true;
            this.label_mhz.Location = new System.Drawing.Point(195, 23);
            this.label_mhz.Name = "label_mhz";
            this.label_mhz.Size = new System.Drawing.Size(28, 13);
            this.label_mhz.TabIndex = 2;
            this.label_mhz.Text = "МГц";
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
            this.numericUpDown.Value = new decimal(new int[] {
            1033,
            0,
            0,
            65536});
            // 
            // button_add_to_base
            // 
            this.button_add_to_base.Location = new System.Drawing.Point(339, 284);
            this.button_add_to_base.Name = "button_add_to_base";
            this.button_add_to_base.Size = new System.Drawing.Size(66, 40);
            this.button_add_to_base.TabIndex = 6;
            this.button_add_to_base.Text = "Добавить в базу";
            this.toolTip1.SetToolTip(this.button_add_to_base, "Дописать канал в файл");
            this.button_add_to_base.UseVisualStyleBackColor = true;
            this.button_add_to_base.Click += new System.EventHandler(this.button_add_to_base_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(415, 284);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(63, 40);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Form_frequency_save
            // 
            this.AcceptButton = this.button_add_to_base;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 333);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.groupBox_frequency);
            this.Controls.Add(this.button_add_to_base);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_frequency_save";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сохранение частоты";
            this.groupBox_frequency.ResumeLayout(false);
            this.groupBox_frequency.PerformLayout();
            this.groupBox_Squelch.ResumeLayout(false);
            this.groupBox_Squelch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Squelch)).EndInit();
            this.groupBox_Level.ResumeLayout(false);
            this.groupBox_Level.PerformLayout();
            this.groupBox_modulation.ResumeLayout(false);
            this.groupBox_modulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_frequency;
        private System.Windows.Forms.GroupBox groupBox_Level;
        private System.Windows.Forms.Label label_Level_minimum;
        private System.Windows.Forms.Label label_Level_current;
        private System.Windows.Forms.Label label_Level_min;
        private System.Windows.Forms.Label label_Level_maximum;
        private System.Windows.Forms.Label label_Level_curr;
        private System.Windows.Forms.Label label_Level_max;
        private VerticalProgressBar progressBar_s_meter;
        private System.Windows.Forms.CheckBox checkBox_ATT;
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
        private System.Windows.Forms.Label label_mhz;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button button_add_to_base;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_squelch_level;
        private System.Windows.Forms.Label label_200;
        private System.Windows.Forms.Label label_150;
        private System.Windows.Forms.Label label_100;
        private System.Windows.Forms.Label label_50;
        private System.Windows.Forms.GroupBox groupBox_Squelch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar_Squelch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Cancel;
    }
}