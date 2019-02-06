namespace PortControlDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_portNameSend = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_portNameReceive = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_baudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_dataBit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_stopBit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_checkBit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_timeout = new System.Windows.Forms.ComboBox();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_send = new System.Windows.Forms.Button();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_receive = new System.Windows.Forms.TextBox();
            this.Btn_receive = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口通信参数设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "发送端:";
            // 
            // cb_portNameSend
            // 
            this.cb_portNameSend.FormattingEnabled = true;
            this.cb_portNameSend.Location = new System.Drawing.Point(83, 62);
            this.cb_portNameSend.Name = "cb_portNameSend";
            this.cb_portNameSend.Size = new System.Drawing.Size(101, 20);
            this.cb_portNameSend.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "接受端:";
            // 
            // cb_portNameReceive
            // 
            this.cb_portNameReceive.FormattingEnabled = true;
            this.cb_portNameReceive.Location = new System.Drawing.Point(83, 88);
            this.cb_portNameReceive.Name = "cb_portNameReceive";
            this.cb_portNameReceive.Size = new System.Drawing.Size(101, 20);
            this.cb_portNameReceive.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "波特率:";
            // 
            // cb_baudRate
            // 
            this.cb_baudRate.FormattingEnabled = true;
            this.cb_baudRate.Location = new System.Drawing.Point(83, 130);
            this.cb_baudRate.Name = "cb_baudRate";
            this.cb_baudRate.Size = new System.Drawing.Size(101, 20);
            this.cb_baudRate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "数据位:";
            // 
            // cb_dataBit
            // 
            this.cb_dataBit.FormattingEnabled = true;
            this.cb_dataBit.Location = new System.Drawing.Point(83, 170);
            this.cb_dataBit.Name = "cb_dataBit";
            this.cb_dataBit.Size = new System.Drawing.Size(101, 20);
            this.cb_dataBit.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "停止位:";
            // 
            // cb_stopBit
            // 
            this.cb_stopBit.FormattingEnabled = true;
            this.cb_stopBit.Location = new System.Drawing.Point(83, 210);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.Size = new System.Drawing.Size(101, 20);
            this.cb_stopBit.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "校验位:";
            // 
            // cb_checkBit
            // 
            this.cb_checkBit.FormattingEnabled = true;
            this.cb_checkBit.Location = new System.Drawing.Point(83, 256);
            this.cb_checkBit.Name = "cb_checkBit";
            this.cb_checkBit.Size = new System.Drawing.Size(101, 20);
            this.cb_checkBit.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "超时ms";
            // 
            // cb_timeout
            // 
            this.cb_timeout.FormattingEnabled = true;
            this.cb_timeout.Location = new System.Drawing.Point(83, 304);
            this.cb_timeout.Name = "cb_timeout";
            this.cb_timeout.Size = new System.Drawing.Size(101, 20);
            this.cb_timeout.TabIndex = 2;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(32, 362);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(152, 40);
            this.Btn_Open.TabIndex = 3;
            this.Btn_Open.Text = "打开发送接受端口";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_send);
            this.panel1.Controls.Add(this.tb_send);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(273, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 205);
            this.panel1.TabIndex = 4;
            // 
            // Btn_send
            // 
            this.Btn_send.Location = new System.Drawing.Point(366, 167);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(148, 23);
            this.Btn_send.TabIndex = 2;
            this.Btn_send.Text = "发送数据";
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(24, 40);
            this.tb_send.Multiline = true;
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(490, 102);
            this.tb_send.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "发送管理\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_receive);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tb_receive);
            this.panel2.Location = new System.Drawing.Point(273, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 213);
            this.panel2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "接受管理\r\n";
            // 
            // tb_receive
            // 
            this.tb_receive.Location = new System.Drawing.Point(24, 53);
            this.tb_receive.Multiline = true;
            this.tb_receive.Name = "tb_receive";
            this.tb_receive.Size = new System.Drawing.Size(490, 102);
            this.tb_receive.TabIndex = 1;
            // 
            // Btn_receive
            // 
            this.Btn_receive.Location = new System.Drawing.Point(366, 172);
            this.Btn_receive.Name = "Btn_receive";
            this.Btn_receive.Size = new System.Drawing.Size(148, 23);
            this.Btn_receive.TabIndex = 2;
            this.Btn_receive.Text = "接受数据";
            this.Btn_receive.UseVisualStyleBackColor = true;
            this.Btn_receive.Click += new System.EventHandler(this.Btn_receive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.cb_timeout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_checkBit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_stopBit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_dataBit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_baudRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_portNameReceive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_portNameSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FrmProtControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_portNameSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_portNameReceive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_baudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_dataBit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_stopBit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_checkBit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_timeout;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_send;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_receive;
        private System.Windows.Forms.TextBox tb_receive;
    }
}

