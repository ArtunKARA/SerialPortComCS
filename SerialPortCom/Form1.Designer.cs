namespace SerialPortCom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRtsEnable = new System.Windows.Forms.CheckBox();
            this.cbDrtEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParityBits = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbDataBirts = new System.Windows.Forms.ComboBox();
            this.cbBaundRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbComPortStatus = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btSendData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbWrite = new System.Windows.Forms.CheckBox();
            this.cbWriteLine = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbUssingEnter = new System.Windows.Forms.CheckBox();
            this.cbUssingButton = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbDataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbAddToOldData = new System.Windows.Forms.CheckBox();
            this.cbAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btClearDataIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRtsEnable);
            this.groupBox1.Controls.Add(this.cbDrtEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbParityBits);
            this.groupBox1.Controls.Add(this.cbStopBits);
            this.groupBox1.Controls.Add(this.cbDataBirts);
            this.groupBox1.Controls.Add(this.cbBaundRate);
            this.groupBox1.Controls.Add(this.cbComPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // cbRtsEnable
            // 
            this.cbRtsEnable.AutoSize = true;
            this.cbRtsEnable.Location = new System.Drawing.Point(133, 205);
            this.cbRtsEnable.Name = "cbRtsEnable";
            this.cbRtsEnable.Size = new System.Drawing.Size(103, 20);
            this.cbRtsEnable.TabIndex = 10;
            this.cbRtsEnable.Text = "RTS Enable";
            this.cbRtsEnable.UseVisualStyleBackColor = true;
            this.cbRtsEnable.CheckedChanged += new System.EventHandler(this.cbRtsEnable_CheckedChanged);
            // 
            // cbDrtEnable
            // 
            this.cbDrtEnable.AutoSize = true;
            this.cbDrtEnable.Location = new System.Drawing.Point(15, 205);
            this.cbDrtEnable.Name = "cbDrtEnable";
            this.cbDrtEnable.Size = new System.Drawing.Size(104, 20);
            this.cbDrtEnable.TabIndex = 4;
            this.cbDrtEnable.Text = "DRT Enable";
            this.cbDrtEnable.UseVisualStyleBackColor = true;
            this.cbDrtEnable.CheckedChanged += new System.EventHandler(this.cbDrtEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bıts";
            // 
            // cbParityBits
            // 
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParityBits.Location = new System.Drawing.Point(107, 156);
            this.cbParityBits.Name = "cbParityBits";
            this.cbParityBits.Size = new System.Drawing.Size(121, 24);
            this.cbParityBits.TabIndex = 8;
            this.cbParityBits.Text = "None";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(107, 126);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 24);
            this.cbStopBits.TabIndex = 7;
            this.cbStopBits.Text = "One";
            // 
            // cbDataBirts
            // 
            this.cbDataBirts.FormattingEnabled = true;
            this.cbDataBirts.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDataBirts.Location = new System.Drawing.Point(107, 96);
            this.cbDataBirts.Name = "cbDataBirts";
            this.cbDataBirts.Size = new System.Drawing.Size(121, 24);
            this.cbDataBirts.TabIndex = 6;
            this.cbDataBirts.Text = "8";
            // 
            // cbBaundRate
            // 
            this.cbBaundRate.FormattingEnabled = true;
            this.cbBaundRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cbBaundRate.Location = new System.Drawing.Point(107, 66);
            this.cbBaundRate.Name = "cbBaundRate";
            this.cbBaundRate.Size = new System.Drawing.Size(121, 24);
            this.cbBaundRate.TabIndex = 5;
            this.cbBaundRate.Text = "9600";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(107, 34);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 24);
            this.cbComPort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baund Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.btClose);
            this.groupBox2.Controls.Add(this.btOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbComPortStatus);
            this.groupBox6.Location = new System.Drawing.Point(107, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(199, 78);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Com Port Status";
            // 
            // lbComPortStatus
            // 
            this.lbComPortStatus.AutoSize = true;
            this.lbComPortStatus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbComPortStatus.ForeColor = System.Drawing.Color.Red;
            this.lbComPortStatus.Location = new System.Drawing.Point(63, 30);
            this.lbComPortStatus.Name = "lbComPortStatus";
            this.lbComPortStatus.Size = new System.Drawing.Size(58, 31);
            this.lbComPortStatus.TabIndex = 6;
            this.lbComPortStatus.Text = "OFF";
            this.lbComPortStatus.Click += new System.EventHandler(this.lbComPortStatus_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(15, 58);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(15, 21);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btSendData
            // 
            this.btSendData.Location = new System.Drawing.Point(3, 244);
            this.btSendData.Name = "btSendData";
            this.btSendData.Size = new System.Drawing.Size(125, 44);
            this.btSendData.TabIndex = 2;
            this.btSendData.Text = "Send Data";
            this.btSendData.UseVisualStyleBackColor = true;
            this.btSendData.Click += new System.EventHandler(this.btSendData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 201);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear Data Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbDataOutLength);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btSendData);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(330, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 388);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // lbDataOutLength
            // 
            this.lbDataOutLength.AutoSize = true;
            this.lbDataOutLength.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataOutLength.Location = new System.Drawing.Point(126, 352);
            this.lbDataOutLength.Name = "lbDataOutLength";
            this.lbDataOutLength.Size = new System.Drawing.Size(25, 19);
            this.lbDataOutLength.TabIndex = 6;
            this.lbDataOutLength.Text = "00";
            this.lbDataOutLength.Click += new System.EventHandler(this.lbDataOutLength_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data Out Length:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbWrite);
            this.groupBox5.Controls.Add(this.cbWriteLine);
            this.groupBox5.Location = new System.Drawing.Point(260, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 92);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // cbWrite
            // 
            this.cbWrite.AutoSize = true;
            this.cbWrite.Location = new System.Drawing.Point(6, 60);
            this.cbWrite.Name = "cbWrite";
            this.cbWrite.Size = new System.Drawing.Size(60, 20);
            this.cbWrite.TabIndex = 1;
            this.cbWrite.Text = "Write";
            this.cbWrite.UseVisualStyleBackColor = true;
            this.cbWrite.CheckedChanged += new System.EventHandler(this.cbWrite_CheckedChanged);
            // 
            // cbWriteLine
            // 
            this.cbWriteLine.AutoSize = true;
            this.cbWriteLine.Location = new System.Drawing.Point(6, 20);
            this.cbWriteLine.Name = "cbWriteLine";
            this.cbWriteLine.Size = new System.Drawing.Size(85, 20);
            this.cbWriteLine.TabIndex = 0;
            this.cbWriteLine.Text = "WriteLine";
            this.cbWriteLine.UseVisualStyleBackColor = true;
            this.cbWriteLine.CheckedChanged += new System.EventHandler(this.cbWriteLine_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbUssingEnter);
            this.groupBox4.Controls.Add(this.cbUssingButton);
            this.groupBox4.Location = new System.Drawing.Point(131, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 92);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // cbUssingEnter
            // 
            this.cbUssingEnter.AutoSize = true;
            this.cbUssingEnter.Location = new System.Drawing.Point(6, 61);
            this.cbUssingEnter.Name = "cbUssingEnter";
            this.cbUssingEnter.Size = new System.Drawing.Size(105, 20);
            this.cbUssingEnter.TabIndex = 1;
            this.cbUssingEnter.Text = "Ussing Enter";
            this.cbUssingEnter.UseVisualStyleBackColor = true;
            // 
            // cbUssingButton
            // 
            this.cbUssingButton.AutoSize = true;
            this.cbUssingButton.Location = new System.Drawing.Point(6, 21);
            this.cbUssingButton.Name = "cbUssingButton";
            this.cbUssingButton.Size = new System.Drawing.Size(111, 20);
            this.cbUssingButton.TabIndex = 0;
            this.cbUssingButton.Text = "Ussing Button";
            this.cbUssingButton.UseVisualStyleBackColor = true;
            this.cbUssingButton.CheckedChanged += new System.EventHandler(this.cbUssingButton_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbDataInLength);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.btClearDataIn);
            this.groupBox7.Location = new System.Drawing.Point(728, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(392, 388);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Receiver Control";
            // 
            // lbDataInLength
            // 
            this.lbDataInLength.AutoSize = true;
            this.lbDataInLength.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInLength.Location = new System.Drawing.Point(126, 352);
            this.lbDataInLength.Name = "lbDataInLength";
            this.lbDataInLength.Size = new System.Drawing.Size(25, 19);
            this.lbDataInLength.TabIndex = 6;
            this.lbDataInLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data In Length:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 201);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbAddToOldData);
            this.groupBox9.Controls.Add(this.cbAlwaysUpdate);
            this.groupBox9.Location = new System.Drawing.Point(189, 243);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(153, 92);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            // 
            // cbAddToOldData
            // 
            this.cbAddToOldData.AutoSize = true;
            this.cbAddToOldData.Location = new System.Drawing.Point(6, 61);
            this.cbAddToOldData.Name = "cbAddToOldData";
            this.cbAddToOldData.Size = new System.Drawing.Size(130, 20);
            this.cbAddToOldData.TabIndex = 1;
            this.cbAddToOldData.Text = "Add To Old Data";
            this.cbAddToOldData.UseVisualStyleBackColor = true;
            this.cbAddToOldData.CheckedChanged += new System.EventHandler(this.cbAddToOldData_CheckedChanged);
            // 
            // cbAlwaysUpdate
            // 
            this.cbAlwaysUpdate.AutoSize = true;
            this.cbAlwaysUpdate.Location = new System.Drawing.Point(6, 21);
            this.cbAlwaysUpdate.Name = "cbAlwaysUpdate";
            this.cbAlwaysUpdate.Size = new System.Drawing.Size(120, 20);
            this.cbAlwaysUpdate.TabIndex = 0;
            this.cbAlwaysUpdate.Text = "Always Update";
            this.cbAlwaysUpdate.UseVisualStyleBackColor = true;
            this.cbAlwaysUpdate.CheckedChanged += new System.EventHandler(this.cbAlwaysUpdate_CheckedChanged);
            // 
            // btClearDataIn
            // 
            this.btClearDataIn.Location = new System.Drawing.Point(61, 244);
            this.btClearDataIn.Name = "btClearDataIn";
            this.btClearDataIn.Size = new System.Drawing.Size(125, 97);
            this.btClearDataIn.TabIndex = 4;
            this.btClearDataIn.Text = "Clear Data In";
            this.btClearDataIn.UseVisualStyleBackColor = true;
            this.btClearDataIn.Click += new System.EventHandler(this.btClearDataIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.Text = "C# COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParityBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbDataBirts;
        private System.Windows.Forms.ComboBox cbBaundRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btSendData;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox cbRtsEnable;
        private System.Windows.Forms.CheckBox cbDrtEnable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbComPortStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbWrite;
        private System.Windows.Forms.CheckBox cbWriteLine;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbUssingEnter;
        private System.Windows.Forms.CheckBox cbUssingButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cbAddToOldData;
        private System.Windows.Forms.CheckBox cbAlwaysUpdate;
        private System.Windows.Forms.Button btClearDataIn;
    }
}

