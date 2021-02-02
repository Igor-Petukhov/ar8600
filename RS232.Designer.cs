
namespace ar8600
{
    partial class RS232
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
            this.groupBoxSettingsRS232 = new System.Windows.Forms.GroupBox();
            this.label_Handshake = new System.Windows.Forms.Label();
            this.label_StopBits = new System.Windows.Forms.Label();
            this.label_Parity = new System.Windows.Forms.Label();
            this.label_DataBits = new System.Windows.Forms.Label();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.label_PortName = new System.Windows.Forms.Label();
            this.comboBox_Handshake = new System.Windows.Forms.ComboBox();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.comboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.button_resetDefault = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBoxSettingsRS232.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettingsRS232
            // 
            this.groupBoxSettingsRS232.Controls.Add(this.label_Handshake);
            this.groupBoxSettingsRS232.Controls.Add(this.label_StopBits);
            this.groupBoxSettingsRS232.Controls.Add(this.label_Parity);
            this.groupBoxSettingsRS232.Controls.Add(this.label_DataBits);
            this.groupBoxSettingsRS232.Controls.Add(this.label_BaudRate);
            this.groupBoxSettingsRS232.Controls.Add(this.label_PortName);
            this.groupBoxSettingsRS232.Controls.Add(this.comboBox_Handshake);
            this.groupBoxSettingsRS232.Controls.Add(this.comboBox_StopBits);
            this.groupBoxSettingsRS232.Controls.Add(this.comboBox_Parity);
            this.groupBoxSettingsRS232.Controls.Add(this.comboBox_DataBits);
            this.groupBoxSettingsRS232.Controls.Add(this.comboBox_BaudRate);
            this.groupBoxSettingsRS232.Controls.Add(this.comboBox_PortName);
            this.groupBoxSettingsRS232.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettingsRS232.Name = "groupBoxSettingsRS232";
            this.groupBoxSettingsRS232.Size = new System.Drawing.Size(361, 254);
            this.groupBoxSettingsRS232.TabIndex = 0;
            this.groupBoxSettingsRS232.TabStop = false;
            this.groupBoxSettingsRS232.Text = "Параметры";
            // 
            // label_Handshake
            // 
            this.label_Handshake.AutoSize = true;
            this.label_Handshake.Location = new System.Drawing.Point(63, 193);
            this.label_Handshake.Name = "label_Handshake";
            this.label_Handshake.Size = new System.Drawing.Size(115, 13);
            this.label_Handshake.TabIndex = 11;
            this.label_Handshake.Text = "Управление потоком";
            // 
            // label_StopBits
            // 
            this.label_StopBits.AutoSize = true;
            this.label_StopBits.Location = new System.Drawing.Point(93, 158);
            this.label_StopBits.Name = "label_StopBits";
            this.label_StopBits.Size = new System.Drawing.Size(85, 13);
            this.label_StopBits.TabIndex = 10;
            this.label_StopBits.Text = "Стоповые биты";
            // 
            // label_Parity
            // 
            this.label_Parity.AutoSize = true;
            this.label_Parity.Location = new System.Drawing.Point(123, 122);
            this.label_Parity.Name = "label_Parity";
            this.label_Parity.Size = new System.Drawing.Size(55, 13);
            this.label_Parity.TabIndex = 9;
            this.label_Parity.Text = "Четность";
            // 
            // label_DataBits
            // 
            this.label_DataBits.AutoSize = true;
            this.label_DataBits.Location = new System.Drawing.Point(105, 87);
            this.label_DataBits.Name = "label_DataBits";
            this.label_DataBits.Size = new System.Drawing.Size(73, 13);
            this.label_DataBits.TabIndex = 8;
            this.label_DataBits.Text = "Биты данных";
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Location = new System.Drawing.Point(87, 54);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(92, 13);
            this.label_BaudRate.TabIndex = 7;
            this.label_BaudRate.Text = "Скорость (бит/с)";
            // 
            // label_PortName
            // 
            this.label_PortName.AutoSize = true;
            this.label_PortName.Location = new System.Drawing.Point(106, 22);
            this.label_PortName.Name = "label_PortName";
            this.label_PortName.Size = new System.Drawing.Size(73, 13);
            this.label_PortName.TabIndex = 6;
            this.label_PortName.Text = "Номер порта";
            // 
            // comboBox_Handshake
            // 
            this.comboBox_Handshake.FormattingEnabled = true;
            this.comboBox_Handshake.Location = new System.Drawing.Point(207, 190);
            this.comboBox_Handshake.Name = "comboBox_Handshake";
            this.comboBox_Handshake.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Handshake.TabIndex = 5;
            this.comboBox_Handshake.SelectedValueChanged += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_Handshake.Enter += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_Handshake.Leave += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Location = new System.Drawing.Point(207, 155);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(121, 21);
            this.comboBox_StopBits.TabIndex = 4;
            this.comboBox_StopBits.SelectedValueChanged += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_StopBits.Enter += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_StopBits.Leave += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Location = new System.Drawing.Point(207, 119);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Parity.TabIndex = 3;
            this.comboBox_Parity.SelectedValueChanged += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_Parity.Enter += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_Parity.Leave += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            // 
            // comboBox_DataBits
            // 
            this.comboBox_DataBits.FormattingEnabled = true;
            this.comboBox_DataBits.Items.AddRange(new object[] {
            "8"});
            this.comboBox_DataBits.Location = new System.Drawing.Point(207, 84);
            this.comboBox_DataBits.Name = "comboBox_DataBits";
            this.comboBox_DataBits.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DataBits.TabIndex = 2;
            this.comboBox_DataBits.SelectedValueChanged += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_DataBits.Enter += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_DataBits.Leave += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(207, 51);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BaudRate.TabIndex = 1;
            this.comboBox_BaudRate.SelectedValueChanged += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_BaudRate.Enter += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_BaudRate.Leave += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(207, 19);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PortName.TabIndex = 0;
            this.comboBox_PortName.SelectedValueChanged += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_PortName.Enter += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            this.comboBox_PortName.Leave += new System.EventHandler(this.comboBox_any_SelectedIndexChanged);
            // 
            // button_resetDefault
            // 
            this.button_resetDefault.Location = new System.Drawing.Point(228, 272);
            this.button_resetDefault.Name = "button_resetDefault";
            this.button_resetDefault.Size = new System.Drawing.Size(145, 23);
            this.button_resetDefault.TabIndex = 12;
            this.button_resetDefault.Text = "Восстановить умолчания";
            this.button_resetDefault.UseVisualStyleBackColor = true;
            this.button_resetDefault.Click += new System.EventHandler(this.button_resetDefault_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(213, 344);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 13;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(298, 344);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 14;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // RS232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 378);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_resetDefault);
            this.Controls.Add(this.groupBoxSettingsRS232);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(401, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 417);
            this.Name = "RS232";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Последовательный порт RS232 (СОМ)";
            this.groupBoxSettingsRS232.ResumeLayout(false);
            this.groupBoxSettingsRS232.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettingsRS232;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.Label label_Handshake;
        private System.Windows.Forms.Label label_StopBits;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.Label label_DataBits;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.Label label_PortName;
        private System.Windows.Forms.ComboBox comboBox_Handshake;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.ComboBox comboBox_DataBits;
        private System.Windows.Forms.Button button_resetDefault;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}