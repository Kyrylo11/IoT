namespace BokhanS7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_scan = new System.Windows.Forms.ComboBox();
            this.cb_cpu = new System.Windows.Forms.ComboBox();
            this.label_settings = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.scan_value = new System.Windows.Forms.Label();
            this.cpu_value = new System.Windows.Forms.Label();
            this.label_scan = new System.Windows.Forms.Label();
            this.label_cpu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cb_reservepump = new System.Windows.Forms.CheckBox();
            this.label_control = new System.Windows.Forms.Label();
            this.cb_primpump = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_state = new System.Windows.Forms.Button();
            this.button_reserve = new System.Windows.Forms.Button();
            this.button_prim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(3, 42);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(189, 55);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.connect);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(191, 42);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(189, 55);
            this.button_disconnect.TabIndex = 1;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.disconnect);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_scan);
            this.panel1.Controls.Add(this.cb_cpu);
            this.panel1.Controls.Add(this.label_settings);
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.scan_value);
            this.panel1.Controls.Add(this.cpu_value);
            this.panel1.Controls.Add(this.label_scan);
            this.panel1.Controls.Add(this.label_cpu);
            this.panel1.Controls.Add(this.button_connect);
            this.panel1.Controls.Add(this.button_disconnect);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 293);
            this.panel1.TabIndex = 2;
            // 
            // cb_scan
            // 
            this.cb_scan.FormattingEnabled = true;
            this.cb_scan.Items.AddRange(new object[] {
            "Single Scan",
            "Continuous Scan"});
            this.cb_scan.Location = new System.Drawing.Point(244, 173);
            this.cb_scan.Name = "cb_scan";
            this.cb_scan.Size = new System.Drawing.Size(121, 24);
            this.cb_scan.TabIndex = 10;
            this.cb_scan.SelectedIndexChanged += new System.EventHandler(this.scan_changed);
            // 
            // cb_cpu
            // 
            this.cb_cpu.FormattingEnabled = true;
            this.cb_cpu.Items.AddRange(new object[] {
            "RUN_P",
            "RUN",
            "STOP"});
            this.cb_cpu.Location = new System.Drawing.Point(14, 173);
            this.cb_cpu.Name = "cb_cpu";
            this.cb_cpu.Size = new System.Drawing.Size(121, 24);
            this.cb_cpu.TabIndex = 9;
            this.cb_cpu.SelectedIndexChanged += new System.EventHandler(this.cpu_changed);
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_settings.Location = new System.Drawing.Point(150, 0);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(83, 25);
            this.label_settings.TabIndex = 8;
            this.label_settings.Text = "Settings";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(14, 260);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(144, 16);
            this.label_author.TabIndex = 6;
            this.label_author.Text = "(c) Kirill Bokhan, 555aM";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(275, 260);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(90, 16);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Disconnected";
            // 
            // scan_value
            // 
            this.scan_value.AutoSize = true;
            this.scan_value.Location = new System.Drawing.Point(115, 145);
            this.scan_value.Name = "scan_value";
            this.scan_value.Size = new System.Drawing.Size(0, 16);
            this.scan_value.TabIndex = 5;
            // 
            // cpu_value
            // 
            this.cpu_value.AutoSize = true;
            this.cpu_value.Location = new System.Drawing.Point(115, 110);
            this.cpu_value.Name = "cpu_value";
            this.cpu_value.Size = new System.Drawing.Size(0, 16);
            this.cpu_value.TabIndex = 4;
            // 
            // label_scan
            // 
            this.label_scan.AutoSize = true;
            this.label_scan.Location = new System.Drawing.Point(14, 145);
            this.label_scan.Name = "label_scan";
            this.label_scan.Size = new System.Drawing.Size(79, 16);
            this.label_scan.TabIndex = 3;
            this.label_scan.Text = "Scan mode:";
            this.label_scan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_cpu
            // 
            this.label_cpu.AutoSize = true;
            this.label_cpu.Location = new System.Drawing.Point(14, 110);
            this.label_cpu.Name = "label_cpu";
            this.label_cpu.Size = new System.Drawing.Size(70, 16);
            this.label_cpu.TabIndex = 2;
            this.label_cpu.Text = "CPU state:";
            this.label_cpu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.cb_reservepump);
            this.panel2.Controls.Add(this.label_control);
            this.panel2.Controls.Add(this.cb_primpump);
            this.panel2.Location = new System.Drawing.Point(12, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 100);
            this.panel2.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(262, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Manual";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rb_manual);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(262, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Automatic";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rb_auto);
            // 
            // cb_reservepump
            // 
            this.cb_reservepump.AutoSize = true;
            this.cb_reservepump.Location = new System.Drawing.Point(17, 58);
            this.cb_reservepump.Name = "cb_reservepump";
            this.cb_reservepump.Size = new System.Drawing.Size(118, 20);
            this.cb_reservepump.TabIndex = 8;
            this.cb_reservepump.Text = "Reserve pump";
            this.cb_reservepump.UseVisualStyleBackColor = true;
            this.cb_reservepump.CheckedChanged += new System.EventHandler(this.reserve_pump);
            // 
            // label_control
            // 
            this.label_control.AutoSize = true;
            this.label_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_control.Location = new System.Drawing.Point(150, 0);
            this.label_control.Name = "label_control";
            this.label_control.Size = new System.Drawing.Size(75, 25);
            this.label_control.TabIndex = 7;
            this.label_control.Text = "Control";
            // 
            // cb_primpump
            // 
            this.cb_primpump.AutoSize = true;
            this.cb_primpump.Location = new System.Drawing.Point(17, 32);
            this.cb_primpump.Name = "cb_primpump";
            this.cb_primpump.Size = new System.Drawing.Size(112, 20);
            this.cb_primpump.TabIndex = 0;
            this.cb_primpump.Text = "Primary pump";
            this.cb_primpump.UseVisualStyleBackColor = true;
            this.cb_primpump.CheckedChanged += new System.EventHandler(this.prim_changed);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_state);
            this.panel3.Controls.Add(this.button_reserve);
            this.panel3.Controls.Add(this.button_prim);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(403, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 399);
            this.panel3.TabIndex = 4;
            // 
            // button_state
            // 
            this.button_state.Enabled = false;
            this.button_state.Location = new System.Drawing.Point(144, 187);
            this.button_state.Name = "button_state";
            this.button_state.Size = new System.Drawing.Size(75, 41);
            this.button_state.TabIndex = 3;
            this.button_state.Text = "State";
            this.button_state.UseVisualStyleBackColor = true;
            // 
            // button_reserve
            // 
            this.button_reserve.Enabled = false;
            this.button_reserve.Location = new System.Drawing.Point(30, 220);
            this.button_reserve.Name = "button_reserve";
            this.button_reserve.Size = new System.Drawing.Size(75, 56);
            this.button_reserve.TabIndex = 2;
            this.button_reserve.Text = "Reserve pump";
            this.button_reserve.UseVisualStyleBackColor = true;
            // 
            // button_prim
            // 
            this.button_prim.Enabled = false;
            this.button_prim.Location = new System.Drawing.Point(30, 145);
            this.button_prim.Name = "button_prim";
            this.button_prim.Size = new System.Drawing.Size(75, 52);
            this.button_prim.TabIndex = 1;
            this.button_prim.Text = "Primary pump";
            this.button_prim.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pump application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label scan_value;
        private System.Windows.Forms.Label cpu_value;
        private System.Windows.Forms.Label label_scan;
        private System.Windows.Forms.Label label_cpu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_settings;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox cb_reservepump;
        private System.Windows.Forms.Label label_control;
        private System.Windows.Forms.CheckBox cb_primpump;
        private System.Windows.Forms.Button button_state;
        private System.Windows.Forms.Button button_reserve;
        private System.Windows.Forms.Button button_prim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_scan;
        private System.Windows.Forms.ComboBox cb_cpu;
        private System.Windows.Forms.Timer timer1;
    }
}

