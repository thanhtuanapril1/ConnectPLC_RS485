namespace WindowsFormsApplication1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpRW = new System.Windows.Forms.GroupBox();
            this.btReadDigital = new System.Windows.Forms.Button();
            this.btWriteCoil = new System.Windows.Forms.Button();
            this.btReadCoil = new System.Windows.Forms.Button();
            this.btReadAnalog = new System.Windows.Forms.Button();
            this.btWriteHolding = new System.Windows.Forms.Button();
            this.btReadHolding = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxPort = new System.Windows.Forms.ComboBox();
            this.txtValue_1 = new System.Windows.Forms.TextBox();
            this.txtValue_2 = new System.Windows.Forms.TextBox();
            this.txtValue_3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btReadHoldingAuto = new System.Windows.Forms.Button();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.lblTransCount = new System.Windows.Forms.Label();
            this.grpRW.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parity";
            // 
            // cBoxBaudrate
            // 
            this.cBoxBaudrate.FormattingEnabled = true;
            this.cBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.cBoxBaudrate.Location = new System.Drawing.Point(120, 46);
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBaudrate.TabIndex = 2;
            this.cBoxBaudrate.Text = "115200";
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cBoxParity.Location = new System.Drawing.Point(120, 73);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(121, 21);
            this.cBoxParity.TabIndex = 2;
            this.cBoxParity.Text = "None";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(46, 111);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(125, 43);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Location = new System.Drawing.Point(197, 111);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(125, 43);
            this.btDisconnect.TabIndex = 3;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(78, 406);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "-";
            // 
            // grpRW
            // 
            this.grpRW.Controls.Add(this.lblTransCount);
            this.grpRW.Controls.Add(this.btReadDigital);
            this.grpRW.Controls.Add(this.lblTimerCount);
            this.grpRW.Controls.Add(this.btWriteCoil);
            this.grpRW.Controls.Add(this.btReadHoldingAuto);
            this.grpRW.Controls.Add(this.txtValue_3);
            this.grpRW.Controls.Add(this.btReadCoil);
            this.grpRW.Controls.Add(this.txtValue_2);
            this.grpRW.Controls.Add(this.btReadAnalog);
            this.grpRW.Controls.Add(this.txtValue_1);
            this.grpRW.Controls.Add(this.btWriteHolding);
            this.grpRW.Controls.Add(this.btReadHolding);
            this.grpRW.Controls.Add(this.txtValue);
            this.grpRW.Controls.Add(this.label6);
            this.grpRW.Controls.Add(this.txtReg);
            this.grpRW.Controls.Add(this.label5);
            this.grpRW.Enabled = false;
            this.grpRW.Location = new System.Drawing.Point(12, 160);
            this.grpRW.Name = "grpRW";
            this.grpRW.Size = new System.Drawing.Size(622, 243);
            this.grpRW.TabIndex = 6;
            this.grpRW.TabStop = false;
            this.grpRW.Text = "Read/Write";
            // 
            // btReadDigital
            // 
            this.btReadDigital.Location = new System.Drawing.Point(351, 45);
            this.btReadDigital.Name = "btReadDigital";
            this.btReadDigital.Size = new System.Drawing.Size(75, 50);
            this.btReadDigital.TabIndex = 7;
            this.btReadDigital.Text = "Read Digital";
            this.btReadDigital.UseVisualStyleBackColor = true;
            this.btReadDigital.Click += new System.EventHandler(this.btnReadDigital_Click);
            // 
            // btWriteCoil
            // 
            this.btWriteCoil.Location = new System.Drawing.Point(270, 127);
            this.btWriteCoil.Name = "btWriteCoil";
            this.btWriteCoil.Size = new System.Drawing.Size(75, 50);
            this.btWriteCoil.TabIndex = 6;
            this.btWriteCoil.Text = "Write Coil";
            this.btWriteCoil.UseVisualStyleBackColor = true;
            this.btWriteCoil.Click += new System.EventHandler(this.btnWriteCoil_Click);
            // 
            // btReadCoil
            // 
            this.btReadCoil.Location = new System.Drawing.Point(270, 45);
            this.btReadCoil.Name = "btReadCoil";
            this.btReadCoil.Size = new System.Drawing.Size(75, 50);
            this.btReadCoil.TabIndex = 5;
            this.btReadCoil.Text = "Read Coil";
            this.btReadCoil.UseVisualStyleBackColor = true;
            this.btReadCoil.Click += new System.EventHandler(this.btnReadCoil_Click);
            // 
            // btReadAnalog
            // 
            this.btReadAnalog.Location = new System.Drawing.Point(189, 45);
            this.btReadAnalog.Name = "btReadAnalog";
            this.btReadAnalog.Size = new System.Drawing.Size(75, 50);
            this.btReadAnalog.TabIndex = 4;
            this.btReadAnalog.Text = "Read Analog";
            this.btReadAnalog.UseVisualStyleBackColor = true;
            this.btReadAnalog.Click += new System.EventHandler(this.btnReadAnalog_Click);
            // 
            // btWriteHolding
            // 
            this.btWriteHolding.Location = new System.Drawing.Point(108, 127);
            this.btWriteHolding.Name = "btWriteHolding";
            this.btWriteHolding.Size = new System.Drawing.Size(75, 50);
            this.btWriteHolding.TabIndex = 3;
            this.btWriteHolding.Text = "Write Holding";
            this.btWriteHolding.UseVisualStyleBackColor = true;
            this.btWriteHolding.Click += new System.EventHandler(this.btnWriteHolding_Click);
            // 
            // btReadHolding
            // 
            this.btReadHolding.Location = new System.Drawing.Point(108, 45);
            this.btReadHolding.Name = "btReadHolding";
            this.btReadHolding.Size = new System.Drawing.Size(75, 50);
            this.btReadHolding.TabIndex = 2;
            this.btReadHolding.Text = "Read Holding";
            this.btReadHolding.UseVisualStyleBackColor = true;
            this.btReadHolding.Click += new System.EventHandler(this.btnReadHolding_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(108, 101);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(121, 20);
            this.txtValue.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Value";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(108, 19);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(121, 20);
            this.txtReg.TabIndex = 1;
            this.txtReg.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Register";
            // 
            // cBoxPort
            // 
            this.cBoxPort.FormattingEnabled = true;
            this.cBoxPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cBoxPort.Location = new System.Drawing.Point(120, 20);
            this.cBoxPort.Name = "cBoxPort";
            this.cBoxPort.Size = new System.Drawing.Size(121, 21);
            this.cBoxPort.TabIndex = 7;
            this.cBoxPort.Text = "COM4";
            // 
            // txtValue_1
            // 
            this.txtValue_1.Location = new System.Drawing.Point(472, 125);
            this.txtValue_1.Name = "txtValue_1";
            this.txtValue_1.Size = new System.Drawing.Size(121, 20);
            this.txtValue_1.TabIndex = 8;
            // 
            // txtValue_2
            // 
            this.txtValue_2.Location = new System.Drawing.Point(472, 166);
            this.txtValue_2.Name = "txtValue_2";
            this.txtValue_2.Size = new System.Drawing.Size(121, 20);
            this.txtValue_2.TabIndex = 9;
            // 
            // txtValue_3
            // 
            this.txtValue_3.Location = new System.Drawing.Point(472, 210);
            this.txtValue_3.Name = "txtValue_3";
            this.txtValue_3.Size = new System.Drawing.Size(121, 20);
            this.txtValue_3.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btReadHoldingAuto
            // 
            this.btReadHoldingAuto.Location = new System.Drawing.Point(472, 22);
            this.btReadHoldingAuto.Name = "btReadHoldingAuto";
            this.btReadHoldingAuto.Size = new System.Drawing.Size(121, 43);
            this.btReadHoldingAuto.TabIndex = 11;
            this.btReadHoldingAuto.Text = "Read Holding Auto";
            this.btReadHoldingAuto.UseVisualStyleBackColor = true;
            this.btReadHoldingAuto.Click += new System.EventHandler(this.btReadHoldingAuto_Click);
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.Location = new System.Drawing.Point(470, 71);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(64, 13);
            this.lblTimerCount.TabIndex = 12;
            this.lblTimerCount.Text = "Timer Count";
            // 
            // lblTransCount
            // 
            this.lblTransCount.AutoSize = true;
            this.lblTransCount.Location = new System.Drawing.Point(470, 89);
            this.lblTransCount.Name = "lblTransCount";
            this.lblTransCount.Size = new System.Drawing.Size(77, 13);
            this.lblTransCount.TabIndex = 13;
            this.lblTransCount.Text = "Transfer Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 624);
            this.Controls.Add(this.cBoxPort);
            this.Controls.Add(this.grpRW);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cBoxParity);
            this.Controls.Add(this.cBoxBaudrate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Modbus RTU Master";
            this.grpRW.ResumeLayout(false);
            this.grpRW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxBaudrate;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpRW;
        private System.Windows.Forms.Button btReadHolding;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btWriteHolding;
        private System.Windows.Forms.Button btReadAnalog;
        private System.Windows.Forms.Button btReadCoil;
        private System.Windows.Forms.Button btWriteCoil;
        private System.Windows.Forms.Button btReadDigital;
        private System.Windows.Forms.ComboBox cBoxPort;
        private System.Windows.Forms.TextBox txtValue_1;
        private System.Windows.Forms.TextBox txtValue_2;
        private System.Windows.Forms.TextBox txtValue_3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btReadHoldingAuto;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.Label lblTransCount;
    }
}

