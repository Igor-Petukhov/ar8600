
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
            this.groupBox_manual_control = new System.Windows.Forms.GroupBox();
            this.groupBox_sound_recording = new System.Windows.Forms.GroupBox();
            this.label_rec = new System.Windows.Forms.Label();
            this.groupBox_frequency = new System.Windows.Forms.GroupBox();
            this.button_get_status = new System.Windows.Forms.Button();
            this.groupBox_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox_manual_control.SuspendLayout();
            this.groupBox_sound_recording.SuspendLayout();
            this.groupBox_frequency.SuspendLayout();
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
            this.groupBox_settings.Size = new System.Drawing.Size(309, 112);
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
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Внешний вид сканера AR8600");
            // 
            // numericUpDown
            // 
            this.numericUpDown.DecimalPlaces = 4;
            this.numericUpDown.Location = new System.Drawing.Point(104, 19);
            this.numericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.numericUpDown, "Частота сигнала");
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
            this.button_turn_off.Location = new System.Drawing.Point(375, 114);
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
            this.button_disconnect.Location = new System.Drawing.Point(375, 144);
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
            // groupBox_manual_control
            // 
            this.groupBox_manual_control.Controls.Add(this.groupBox_sound_recording);
            this.groupBox_manual_control.Controls.Add(this.groupBox_frequency);
            this.groupBox_manual_control.Controls.Add(this.button_disconnect);
            this.groupBox_manual_control.Controls.Add(this.button_turn_off);
            this.groupBox_manual_control.Controls.Add(this.button_connect);
            this.groupBox_manual_control.Location = new System.Drawing.Point(12, 134);
            this.groupBox_manual_control.Name = "groupBox_manual_control";
            this.groupBox_manual_control.Size = new System.Drawing.Size(484, 173);
            this.groupBox_manual_control.TabIndex = 4;
            this.groupBox_manual_control.TabStop = false;
            this.groupBox_manual_control.Text = "Ручное (пошаговое) управление";
            // 
            // groupBox_sound_recording
            // 
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
            // label_rec
            // 
            this.label_rec.AutoSize = true;
            this.label_rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rec.ForeColor = System.Drawing.Color.Red;
            this.label_rec.Location = new System.Drawing.Point(65, 35);
            this.label_rec.Name = "label_rec";
            this.label_rec.Size = new System.Drawing.Size(0, 13);
            this.label_rec.TabIndex = 2;
            this.toolTip1.SetToolTip(this.label_rec, "Сейчас происходит запись звука в аудиофайл");
            // 
            // groupBox_frequency
            // 
            this.groupBox_frequency.Controls.Add(this.numericUpDown);
            this.groupBox_frequency.Location = new System.Drawing.Point(6, 91);
            this.groupBox_frequency.Name = "groupBox_frequency";
            this.groupBox_frequency.Size = new System.Drawing.Size(338, 76);
            this.groupBox_frequency.TabIndex = 4;
            this.groupBox_frequency.TabStop = false;
            this.groupBox_frequency.Text = "Частота/канал";
            // 
            // button_get_status
            // 
            this.button_get_status.Location = new System.Drawing.Point(275, 355);
            this.button_get_status.Name = "button_get_status";
            this.button_get_status.Size = new System.Drawing.Size(75, 59);
            this.button_get_status.TabIndex = 6;
            this.button_get_status.Text = "Получить текущие данные";
            this.toolTip1.SetToolTip(this.button_get_status, "Сканер вернёт текущие данные");
            this.button_get_status.UseVisualStyleBackColor = true;
            this.button_get_status.Click += new System.EventHandler(this.button_get_status_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.button_get_status);
            this.Controls.Add(this.groupBox_manual_control);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AR8600 управление";
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox_manual_control.ResumeLayout(false);
            this.groupBox_sound_recording.ResumeLayout(false);
            this.groupBox_sound_recording.PerformLayout();
            this.groupBox_frequency.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}