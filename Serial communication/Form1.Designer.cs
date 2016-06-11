namespace Serial_communication
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.button_con = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.richTextBox_send = new System.Windows.Forms.RichTextBox();
            this.serialPort_main = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.Label();
            this.v3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(12, 29);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ports.TabIndex = 1;
            this.comboBox_ports.Click += new System.EventHandler(this.comboBox_ports_Click);
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(12, 71);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 106);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 13);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "Statuts";
            // 
            // button_con
            // 
            this.button_con.Location = new System.Drawing.Point(12, 134);
            this.button_con.Name = "button_con";
            this.button_con.Size = new System.Drawing.Size(121, 23);
            this.button_con.TabIndex = 5;
            this.button_con.Text = "Connect";
            this.button_con.UseVisualStyleBackColor = true;
            this.button_con.Click += new System.EventHandler(this.button_con_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(139, 134);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(121, 23);
            this.button_send.TabIndex = 7;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // richTextBox_send
            // 
            this.richTextBox_send.Location = new System.Drawing.Point(139, 29);
            this.richTextBox_send.Name = "richTextBox_send";
            this.richTextBox_send.Size = new System.Drawing.Size(121, 99);
            this.richTextBox_send.TabIndex = 8;
            this.richTextBox_send.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Recieved Data";
            // 
            // main_timer
            // 
            this.main_timer.Enabled = true;
            this.main_timer.Interval = 10;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wameedh Scientific Club - Khaled Benhouria";
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Location = new System.Drawing.Point(276, 29);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(0, 13);
            this.v1.TabIndex = 13;
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Location = new System.Drawing.Point(335, 29);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(0, 13);
            this.v2.TabIndex = 14;
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Location = new System.Drawing.Point(398, 29);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(0, 13);
            this.v3.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(266, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(167, 99);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 187);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_send);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_con);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.comboBox_baudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_ports);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Serial V1.0 Wameedh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_con;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.RichTextBox richTextBox_send;
        private System.IO.Ports.SerialPort serialPort_main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label v1;
        private System.Windows.Forms.Label v2;
        private System.Windows.Forms.Label v3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

