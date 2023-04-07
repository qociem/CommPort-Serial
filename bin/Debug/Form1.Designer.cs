namespace port_serial
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
            this.CommPort_Control = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.cBoxDATABIT = new System.Windows.Forms.ComboBox();
            this.cBoxSTOPBIT = new System.Windows.Forms.ComboBox();
            this.cBoxPARITYBIT = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tBoxdataA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxdataB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxdataC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxdataE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxdataD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBoxdataG = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxdataF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBoxdataI = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBoxdataH = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tBoxdataJ = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblDataA = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tBoxdataT = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tBoxdataS = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tBoxdataR = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tBoxdataQ = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tBoxdataP = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tBoxdataO = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tBoxdataN = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tBoxdataM = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tBoxdataL = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tBoxdataK = new System.Windows.Forms.TextBox();
            this.lblDataConn = new System.Windows.Forms.Label();
            this.tbox_D_A = new System.Windows.Forms.TextBox();
            this.tbox_U_A = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblUA = new System.Windows.Forms.Label();
            this.CommPort_Control.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommPort_Control
            // 
            this.CommPort_Control.Controls.Add(this.label5);
            this.CommPort_Control.Controls.Add(this.label4);
            this.CommPort_Control.Controls.Add(this.label3);
            this.CommPort_Control.Controls.Add(this.label2);
            this.CommPort_Control.Controls.Add(this.label1);
            this.CommPort_Control.Controls.Add(this.cBoxBAUDRATE);
            this.CommPort_Control.Controls.Add(this.cBoxDATABIT);
            this.CommPort_Control.Controls.Add(this.cBoxSTOPBIT);
            this.CommPort_Control.Controls.Add(this.cBoxPARITYBIT);
            this.CommPort_Control.Controls.Add(this.cBoxCOMPORT);
            this.CommPort_Control.Location = new System.Drawing.Point(27, 23);
            this.CommPort_Control.Name = "CommPort_Control";
            this.CommPort_Control.Size = new System.Drawing.Size(275, 196);
            this.CommPort_Control.TabIndex = 0;
            this.CommPort_Control.TabStop = false;
            this.CommPort_Control.Text = "Comm Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // cBoxBAUDRATE
            // 
            this.cBoxBAUDRATE.FormattingEnabled = true;
            this.cBoxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.cBoxBAUDRATE.Location = new System.Drawing.Point(129, 63);
            this.cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            this.cBoxBAUDRATE.Size = new System.Drawing.Size(121, 24);
            this.cBoxBAUDRATE.TabIndex = 4;
            this.cBoxBAUDRATE.Text = "9600";
            this.cBoxBAUDRATE.SelectedIndexChanged += new System.EventHandler(this.cBoxBAUDRATE_SelectedIndexChanged);
            // 
            // cBoxDATABIT
            // 
            this.cBoxDATABIT.FormattingEnabled = true;
            this.cBoxDATABIT.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDATABIT.Location = new System.Drawing.Point(129, 93);
            this.cBoxDATABIT.Name = "cBoxDATABIT";
            this.cBoxDATABIT.Size = new System.Drawing.Size(121, 24);
            this.cBoxDATABIT.TabIndex = 3;
            this.cBoxDATABIT.Text = "8";
            // 
            // cBoxSTOPBIT
            // 
            this.cBoxSTOPBIT.FormattingEnabled = true;
            this.cBoxSTOPBIT.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxSTOPBIT.Location = new System.Drawing.Point(129, 123);
            this.cBoxSTOPBIT.Name = "cBoxSTOPBIT";
            this.cBoxSTOPBIT.Size = new System.Drawing.Size(121, 24);
            this.cBoxSTOPBIT.TabIndex = 2;
            this.cBoxSTOPBIT.Text = "One";
            // 
            // cBoxPARITYBIT
            // 
            this.cBoxPARITYBIT.FormattingEnabled = true;
            this.cBoxPARITYBIT.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxPARITYBIT.Location = new System.Drawing.Point(129, 153);
            this.cBoxPARITYBIT.Name = "cBoxPARITYBIT";
            this.cBoxPARITYBIT.Size = new System.Drawing.Size(121, 24);
            this.cBoxPARITYBIT.TabIndex = 1;
            this.cBoxPARITYBIT.Text = "None";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(129, 33);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 24);
            this.cBoxCOMPORT.TabIndex = 0;
            this.cBoxCOMPORT.SelectedIndexChanged += new System.EventHandler(this.cBoxCOMPORT_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDataConn);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.btn_Open);
            this.groupBox1.Location = new System.Drawing.Point(27, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(60, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(155, 21);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(95, 40);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "CLOSE";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(38, 24);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(88, 37);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "OPEN";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(886, 482);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 27);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(886, 438);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(108, 27);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send Data";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(93, 438);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(777, 86);
            this.tBoxDataOut.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tBoxdataA
            // 
            this.tBoxdataA.Location = new System.Drawing.Point(494, 37);
            this.tBoxdataA.Multiline = true;
            this.tBoxdataA.Name = "tBoxdataA";
            this.tBoxdataA.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataA.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "TP1";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "TP2";
            // 
            // tBoxdataB
            // 
            this.tBoxdataB.Location = new System.Drawing.Point(494, 75);
            this.tBoxdataB.Multiline = true;
            this.tBoxdataB.Name = "tBoxdataB";
            this.tBoxdataB.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataB.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "TP3";
            // 
            // tBoxdataC
            // 
            this.tBoxdataC.Location = new System.Drawing.Point(494, 112);
            this.tBoxdataC.Multiline = true;
            this.tBoxdataC.Name = "tBoxdataC";
            this.tBoxdataC.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataC.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "TP5";
            // 
            // tBoxdataE
            // 
            this.tBoxdataE.Location = new System.Drawing.Point(494, 186);
            this.tBoxdataE.Multiline = true;
            this.tBoxdataE.Name = "tBoxdataE";
            this.tBoxdataE.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataE.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "TP4";
            // 
            // tBoxdataD
            // 
            this.tBoxdataD.Location = new System.Drawing.Point(494, 149);
            this.tBoxdataD.Multiline = true;
            this.tBoxdataD.Name = "tBoxdataD";
            this.tBoxdataD.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataD.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "TP7";
            // 
            // tBoxdataG
            // 
            this.tBoxdataG.Location = new System.Drawing.Point(494, 260);
            this.tBoxdataG.Multiline = true;
            this.tBoxdataG.Name = "tBoxdataG";
            this.tBoxdataG.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataG.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "TP6";
            // 
            // tBoxdataF
            // 
            this.tBoxdataF.Location = new System.Drawing.Point(494, 223);
            this.tBoxdataF.Multiline = true;
            this.tBoxdataF.Name = "tBoxdataF";
            this.tBoxdataF.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataF.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "TP9";
            // 
            // tBoxdataI
            // 
            this.tBoxdataI.Location = new System.Drawing.Point(494, 334);
            this.tBoxdataI.Multiline = true;
            this.tBoxdataI.Name = "tBoxdataI";
            this.tBoxdataI.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataI.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(418, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "TP8";
            // 
            // tBoxdataH
            // 
            this.tBoxdataH.Location = new System.Drawing.Point(494, 297);
            this.tBoxdataH.Multiline = true;
            this.tBoxdataH.Name = "tBoxdataH";
            this.tBoxdataH.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataH.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(418, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "TP10";
            // 
            // tBoxdataJ
            // 
            this.tBoxdataJ.Location = new System.Drawing.Point(494, 371);
            this.tBoxdataJ.Multiline = true;
            this.tBoxdataJ.Name = "tBoxdataJ";
            this.tBoxdataJ.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataJ.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Test Point";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(506, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 30;
            this.label17.Text = "Voltage";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(611, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "Status";
            // 
            // lblDataA
            // 
            this.lblDataA.AutoSize = true;
            this.lblDataA.Location = new System.Drawing.Point(611, 40);
            this.lblDataA.Name = "lblDataA";
            this.lblDataA.Size = new System.Drawing.Size(13, 17);
            this.lblDataA.TabIndex = 32;
            this.lblDataA.Text = "-";
            this.lblDataA.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1001, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 17);
            this.label20.TabIndex = 56;
            this.label20.Text = "Fail";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1001, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 17);
            this.label21.TabIndex = 55;
            this.label21.Text = "Status";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(896, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 54;
            this.label22.Text = "Voltage";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(788, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 17);
            this.label23.TabIndex = 53;
            this.label23.Text = "Test Point";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(808, 378);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 17);
            this.label24.TabIndex = 52;
            this.label24.Text = "TP20";
            // 
            // tBoxdataT
            // 
            this.tBoxdataT.Location = new System.Drawing.Point(884, 371);
            this.tBoxdataT.Multiline = true;
            this.tBoxdataT.Name = "tBoxdataT";
            this.tBoxdataT.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataT.TabIndex = 51;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(807, 341);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 17);
            this.label25.TabIndex = 50;
            this.label25.Text = "TP19";
            // 
            // tBoxdataS
            // 
            this.tBoxdataS.Location = new System.Drawing.Point(884, 334);
            this.tBoxdataS.Multiline = true;
            this.tBoxdataS.Name = "tBoxdataS";
            this.tBoxdataS.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataS.TabIndex = 49;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(808, 304);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 17);
            this.label26.TabIndex = 48;
            this.label26.Text = "TP18";
            // 
            // tBoxdataR
            // 
            this.tBoxdataR.Location = new System.Drawing.Point(884, 297);
            this.tBoxdataR.Multiline = true;
            this.tBoxdataR.Name = "tBoxdataR";
            this.tBoxdataR.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataR.TabIndex = 47;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(807, 267);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 17);
            this.label27.TabIndex = 46;
            this.label27.Text = "TP17";
            // 
            // tBoxdataQ
            // 
            this.tBoxdataQ.Location = new System.Drawing.Point(884, 260);
            this.tBoxdataQ.Multiline = true;
            this.tBoxdataQ.Name = "tBoxdataQ";
            this.tBoxdataQ.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataQ.TabIndex = 45;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(808, 230);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 17);
            this.label28.TabIndex = 44;
            this.label28.Text = "TP16";
            // 
            // tBoxdataP
            // 
            this.tBoxdataP.Location = new System.Drawing.Point(884, 223);
            this.tBoxdataP.Multiline = true;
            this.tBoxdataP.Name = "tBoxdataP";
            this.tBoxdataP.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataP.TabIndex = 43;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(807, 193);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 17);
            this.label29.TabIndex = 42;
            this.label29.Text = "TP15";
            // 
            // tBoxdataO
            // 
            this.tBoxdataO.Location = new System.Drawing.Point(884, 186);
            this.tBoxdataO.Multiline = true;
            this.tBoxdataO.Name = "tBoxdataO";
            this.tBoxdataO.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataO.TabIndex = 41;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(808, 156);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 17);
            this.label30.TabIndex = 40;
            this.label30.Text = "TP14";
            // 
            // tBoxdataN
            // 
            this.tBoxdataN.Location = new System.Drawing.Point(884, 149);
            this.tBoxdataN.Multiline = true;
            this.tBoxdataN.Name = "tBoxdataN";
            this.tBoxdataN.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataN.TabIndex = 39;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(807, 119);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 17);
            this.label31.TabIndex = 38;
            this.label31.Text = "TP13";
            // 
            // tBoxdataM
            // 
            this.tBoxdataM.Location = new System.Drawing.Point(884, 112);
            this.tBoxdataM.Multiline = true;
            this.tBoxdataM.Name = "tBoxdataM";
            this.tBoxdataM.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataM.TabIndex = 37;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(808, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 17);
            this.label32.TabIndex = 36;
            this.label32.Text = "TP12";
            // 
            // tBoxdataL
            // 
            this.tBoxdataL.Location = new System.Drawing.Point(884, 75);
            this.tBoxdataL.Multiline = true;
            this.tBoxdataL.Name = "tBoxdataL";
            this.tBoxdataL.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataL.TabIndex = 35;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(807, 41);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 17);
            this.label33.TabIndex = 34;
            this.label33.Text = "TP11";
            // 
            // tBoxdataK
            // 
            this.tBoxdataK.Location = new System.Drawing.Point(884, 37);
            this.tBoxdataK.Multiline = true;
            this.tBoxdataK.Name = "tBoxdataK";
            this.tBoxdataK.Size = new System.Drawing.Size(84, 31);
            this.tBoxdataK.TabIndex = 33;
            // 
            // lblDataConn
            // 
            this.lblDataConn.AutoSize = true;
            this.lblDataConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConn.Location = new System.Drawing.Point(119, 73);
            this.lblDataConn.Name = "lblDataConn";
            this.lblDataConn.Size = new System.Drawing.Size(131, 25);
            this.lblDataConn.TabIndex = 57;
            this.lblDataConn.Text = "Disconnected";
            this.lblDataConn.Click += new System.EventHandler(this.lblDataConn_Click);
            // 
            // tbox_D_A
            // 
            this.tbox_D_A.Location = new System.Drawing.Point(670, 37);
            this.tbox_D_A.Multiline = true;
            this.tbox_D_A.Name = "tbox_D_A";
            this.tbox_D_A.Size = new System.Drawing.Size(40, 31);
            this.tbox_D_A.TabIndex = 57;
            // 
            // tbox_U_A
            // 
            this.tbox_U_A.Location = new System.Drawing.Point(727, 37);
            this.tbox_U_A.Multiline = true;
            this.tbox_U_A.Name = "tbox_U_A";
            this.tbox_U_A.Size = new System.Drawing.Size(40, 31);
            this.tbox_U_A.TabIndex = 58;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(672, 86);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(95, 40);
            this.btnSet.TabIndex = 58;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(680, 153);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(13, 17);
            this.lblDA.TabIndex = 59;
            this.lblDA.Text = "-";
            // 
            // lblUA
            // 
            this.lblUA.AutoSize = true;
            this.lblUA.Location = new System.Drawing.Point(742, 153);
            this.lblUA.Name = "lblUA";
            this.lblUA.Size = new System.Drawing.Size(13, 17);
            this.lblUA.TabIndex = 60;
            this.lblUA.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 536);
            this.Controls.Add(this.lblUA);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.tbox_U_A);
            this.Controls.Add(this.tbox_D_A);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tBoxdataT);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tBoxdataS);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tBoxdataR);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.tBoxdataQ);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tBoxdataP);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.tBoxdataO);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.tBoxdataN);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.tBoxdataM);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tBoxdataL);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tBoxdataK);
            this.Controls.Add(this.lblDataA);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tBoxdataJ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tBoxdataI);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tBoxdataH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tBoxdataG);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tBoxdataF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tBoxdataE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tBoxdataD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBoxdataC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxdataB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxdataA);
            this.Controls.Add(this.tBoxDataOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CommPort_Control);
            this.Name = "Form1";
            this.Text = "C# Comm Port Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CommPort_Control.ResumeLayout(false);
            this.CommPort_Control.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CommPort_Control;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxBAUDRATE;
        private System.Windows.Forms.ComboBox cBoxDATABIT;
        private System.Windows.Forms.ComboBox cBoxSTOPBIT;
        private System.Windows.Forms.ComboBox cBoxPARITYBIT;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox tBoxdataA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxdataB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxdataC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxdataE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBoxdataD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBoxdataG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxdataF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBoxdataI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBoxdataH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tBoxdataJ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblDataA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tBoxdataT;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tBoxdataS;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tBoxdataR;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tBoxdataQ;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tBoxdataP;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tBoxdataO;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tBoxdataN;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tBoxdataM;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tBoxdataL;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tBoxdataK;
        private System.Windows.Forms.Label lblDataConn;
        private System.Windows.Forms.TextBox tbox_D_A;
        private System.Windows.Forms.TextBox tbox_U_A;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblUA;
    }
}

