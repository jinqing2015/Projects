namespace HX_1
{
    partial class Form_HX
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_System = new System.Windows.Forms.GroupBox();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_COM = new System.Windows.Forms.Label();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.groupBox_State = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_InputVoltage = new System.Windows.Forms.TextBox();
            this.textBox_Temperature = new System.Windows.Forms.TextBox();
            this.textBox_DirectVoltage = new System.Windows.Forms.TextBox();
            this.textBox_DirectCurrent = new System.Windows.Forms.TextBox();
            this.label_InputVoltage = new System.Windows.Forms.Label();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.label_DirectVoltage = new System.Windows.Forms.Label();
            this.label_DirectCurrent = new System.Windows.Forms.Label();
            this.groupBox_Set = new System.Windows.Forms.GroupBox();
            this.button_OpenClose = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_setOutputCurrent = new System.Windows.Forms.TextBox();
            this.label_SetCurrent = new System.Windows.Forms.Label();
            this.groupBox_System.SuspendLayout();
            this.groupBox_State.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Set.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceived);
            // 
            // groupBox_System
            // 
            this.groupBox_System.Controls.Add(this.button_Disconnect);
            this.groupBox_System.Controls.Add(this.button_Connect);
            this.groupBox_System.Controls.Add(this.label_COM);
            this.groupBox_System.Controls.Add(this.comboBox_COM);
            this.groupBox_System.Controls.Add(this.textBox_Address);
            this.groupBox_System.Controls.Add(this.label_Address);
            this.groupBox_System.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_System.Location = new System.Drawing.Point(14, 12);
            this.groupBox_System.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_System.Name = "groupBox_System";
            this.groupBox_System.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_System.Size = new System.Drawing.Size(519, 86);
            this.groupBox_System.TabIndex = 0;
            this.groupBox_System.TabStop = false;
            this.groupBox_System.Text = "系统";
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.FlatAppearance.BorderSize = 0;
            this.button_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Disconnect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Disconnect.Location = new System.Drawing.Point(408, 34);
            this.button_Disconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(90, 26);
            this.button_Disconnect.TabIndex = 5;
            this.button_Disconnect.Text = "断开连接";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Visible = false;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.SystemColors.Control;
            this.button_Connect.FlatAppearance.BorderSize = 0;
            this.button_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Connect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Connect.Location = new System.Drawing.Point(408, 34);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(72, 26);
            this.button_Connect.TabIndex = 4;
            this.button_Connect.Text = "连接";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_COM
            // 
            this.label_COM.AutoSize = true;
            this.label_COM.Location = new System.Drawing.Point(226, 40);
            this.label_COM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_COM.Name = "label_COM";
            this.label_COM.Size = new System.Drawing.Size(35, 14);
            this.label_COM.TabIndex = 3;
            this.label_COM.Text = "串口";
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(274, 36);
            this.comboBox_COM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(96, 22);
            this.comboBox_COM.TabIndex = 2;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(114, 34);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(74, 23);
            this.textBox_Address.TabIndex = 1;
            this.textBox_Address.TextChanged += new System.EventHandler(this.textBox_Address_TextChanged);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(24, 40);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(84, 14);
            this.label_Address.TabIndex = 0;
            this.label_Address.Text = "地址(1~15):";
            // 
            // groupBox_State
            // 
            this.groupBox_State.Controls.Add(this.label13);
            this.groupBox_State.Controls.Add(this.label12);
            this.groupBox_State.Controls.Add(this.label11);
            this.groupBox_State.Controls.Add(this.label10);
            this.groupBox_State.Controls.Add(this.label9);
            this.groupBox_State.Controls.Add(this.label8);
            this.groupBox_State.Controls.Add(this.label7);
            this.groupBox_State.Controls.Add(this.label6);
            this.groupBox_State.Controls.Add(this.pictureBox8);
            this.groupBox_State.Controls.Add(this.pictureBox7);
            this.groupBox_State.Controls.Add(this.pictureBox6);
            this.groupBox_State.Controls.Add(this.pictureBox5);
            this.groupBox_State.Controls.Add(this.pictureBox4);
            this.groupBox_State.Controls.Add(this.pictureBox3);
            this.groupBox_State.Controls.Add(this.pictureBox2);
            this.groupBox_State.Controls.Add(this.pictureBox1);
            this.groupBox_State.Controls.Add(this.label4);
            this.groupBox_State.Controls.Add(this.label3);
            this.groupBox_State.Controls.Add(this.label2);
            this.groupBox_State.Controls.Add(this.label1);
            this.groupBox_State.Controls.Add(this.textBox_InputVoltage);
            this.groupBox_State.Controls.Add(this.textBox_Temperature);
            this.groupBox_State.Controls.Add(this.textBox_DirectVoltage);
            this.groupBox_State.Controls.Add(this.textBox_DirectCurrent);
            this.groupBox_State.Controls.Add(this.label_InputVoltage);
            this.groupBox_State.Controls.Add(this.label_Temperature);
            this.groupBox_State.Controls.Add(this.label_DirectVoltage);
            this.groupBox_State.Controls.Add(this.label_DirectCurrent);
            this.groupBox_State.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_State.Location = new System.Drawing.Point(14, 102);
            this.groupBox_State.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_State.Name = "groupBox_State";
            this.groupBox_State.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_State.Size = new System.Drawing.Size(519, 180);
            this.groupBox_State.TabIndex = 1;
            this.groupBox_State.TabStop = false;
            this.groupBox_State.Text = "状态(广播地址“0xF0”时，无效)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "风机";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "输出过流";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "输入过压";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 24;
            this.label10.Text = "输出过压";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "短路";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "过温";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "缺相";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "关机";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(388, 141);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(18, 18);
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(388, 108);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(18, 18);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(388, 79);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 18);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(388, 46);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 18);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(282, 142);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(282, 110);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(282, 79);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(282, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(212, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "℃";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(210, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "V";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(210, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // textBox_InputVoltage
            // 
            this.textBox_InputVoltage.Location = new System.Drawing.Point(130, 142);
            this.textBox_InputVoltage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_InputVoltage.Name = "textBox_InputVoltage";
            this.textBox_InputVoltage.Size = new System.Drawing.Size(76, 23);
            this.textBox_InputVoltage.TabIndex = 7;
            // 
            // textBox_Temperature
            // 
            this.textBox_Temperature.Location = new System.Drawing.Point(130, 109);
            this.textBox_Temperature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Temperature.Name = "textBox_Temperature";
            this.textBox_Temperature.Size = new System.Drawing.Size(76, 23);
            this.textBox_Temperature.TabIndex = 6;
            // 
            // textBox_DirectVoltage
            // 
            this.textBox_DirectVoltage.Location = new System.Drawing.Point(130, 76);
            this.textBox_DirectVoltage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DirectVoltage.Name = "textBox_DirectVoltage";
            this.textBox_DirectVoltage.Size = new System.Drawing.Size(76, 23);
            this.textBox_DirectVoltage.TabIndex = 5;
            // 
            // textBox_DirectCurrent
            // 
            this.textBox_DirectCurrent.Location = new System.Drawing.Point(130, 41);
            this.textBox_DirectCurrent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DirectCurrent.Name = "textBox_DirectCurrent";
            this.textBox_DirectCurrent.Size = new System.Drawing.Size(76, 23);
            this.textBox_DirectCurrent.TabIndex = 4;
            // 
            // label_InputVoltage
            // 
            this.label_InputVoltage.AutoSize = true;
            this.label_InputVoltage.Location = new System.Drawing.Point(26, 142);
            this.label_InputVoltage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InputVoltage.Name = "label_InputVoltage";
            this.label_InputVoltage.Size = new System.Drawing.Size(91, 14);
            this.label_InputVoltage.TabIndex = 3;
            this.label_InputVoltage.Text = "输入交流电压";
            // 
            // label_Temperature
            // 
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.Location = new System.Drawing.Point(26, 109);
            this.label_Temperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(35, 14);
            this.label_Temperature.TabIndex = 2;
            this.label_Temperature.Text = "温度";
            // 
            // label_DirectVoltage
            // 
            this.label_DirectVoltage.AutoSize = true;
            this.label_DirectVoltage.Location = new System.Drawing.Point(26, 76);
            this.label_DirectVoltage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DirectVoltage.Name = "label_DirectVoltage";
            this.label_DirectVoltage.Size = new System.Drawing.Size(91, 14);
            this.label_DirectVoltage.TabIndex = 1;
            this.label_DirectVoltage.Text = "直流输出电压";
            // 
            // label_DirectCurrent
            // 
            this.label_DirectCurrent.AutoSize = true;
            this.label_DirectCurrent.Location = new System.Drawing.Point(26, 41);
            this.label_DirectCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DirectCurrent.Name = "label_DirectCurrent";
            this.label_DirectCurrent.Size = new System.Drawing.Size(91, 14);
            this.label_DirectCurrent.TabIndex = 0;
            this.label_DirectCurrent.Text = "直流输出电流";
            // 
            // groupBox_Set
            // 
            this.groupBox_Set.Controls.Add(this.button_OpenClose);
            this.groupBox_Set.Controls.Add(this.button_Submit);
            this.groupBox_Set.Controls.Add(this.label5);
            this.groupBox_Set.Controls.Add(this.textBox_setOutputCurrent);
            this.groupBox_Set.Controls.Add(this.label_SetCurrent);
            this.groupBox_Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Set.Location = new System.Drawing.Point(14, 294);
            this.groupBox_Set.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Set.Name = "groupBox_Set";
            this.groupBox_Set.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Set.Size = new System.Drawing.Size(519, 74);
            this.groupBox_Set.TabIndex = 2;
            this.groupBox_Set.TabStop = false;
            this.groupBox_Set.Text = "设置";
            // 
            // button_OpenClose
            // 
            this.button_OpenClose.FlatAppearance.BorderSize = 0;
            this.button_OpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OpenClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenClose.Location = new System.Drawing.Point(368, 24);
            this.button_OpenClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_OpenClose.Name = "button_OpenClose";
            this.button_OpenClose.Size = new System.Drawing.Size(130, 26);
            this.button_OpenClose.TabIndex = 4;
            this.button_OpenClose.Text = "输出使能";
            this.button_OpenClose.UseVisualStyleBackColor = true;
            this.button_OpenClose.Click += new System.EventHandler(this.button_OpenClose_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.FlatAppearance.BorderSize = 0;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Submit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Submit.Location = new System.Drawing.Point(238, 25);
            this.button_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(72, 26);
            this.button_Submit.TabIndex = 3;
            this.button_Submit.Text = "提交";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(207, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "A";
            // 
            // textBox_setOutputCurrent
            // 
            this.textBox_setOutputCurrent.Location = new System.Drawing.Point(130, 25);
            this.textBox_setOutputCurrent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_setOutputCurrent.Name = "textBox_setOutputCurrent";
            this.textBox_setOutputCurrent.Size = new System.Drawing.Size(76, 23);
            this.textBox_setOutputCurrent.TabIndex = 1;
            // 
            // label_SetCurrent
            // 
            this.label_SetCurrent.AutoSize = true;
            this.label_SetCurrent.Location = new System.Drawing.Point(26, 25);
            this.label_SetCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SetCurrent.Name = "label_SetCurrent";
            this.label_SetCurrent.Size = new System.Drawing.Size(98, 42);
            this.label_SetCurrent.TabIndex = 0;
            this.label_SetCurrent.Text = "设定输出电流\r\n\r\n(1.0~300.00A)";
            // 
            // Form_HX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 386);
            this.Controls.Add(this.groupBox_Set);
            this.Controls.Add(this.groupBox_State);
            this.Controls.Add(this.groupBox_System);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_HX";
            this.Text = "HX-1";
            this.Load += new System.EventHandler(this.Form_HX_Load);
            this.groupBox_System.ResumeLayout(false);
            this.groupBox_System.PerformLayout();
            this.groupBox_State.ResumeLayout(false);
            this.groupBox_State.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Set.ResumeLayout(false);
            this.groupBox_Set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox_System;
        private System.Windows.Forms.GroupBox groupBox_State;
        private System.Windows.Forms.GroupBox groupBox_Set;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label_COM;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_InputVoltage;
        private System.Windows.Forms.Label label_Temperature;
        private System.Windows.Forms.Label label_DirectVoltage;
        private System.Windows.Forms.Label label_DirectCurrent;
        private System.Windows.Forms.TextBox textBox_InputVoltage;
        private System.Windows.Forms.TextBox textBox_Temperature;
        private System.Windows.Forms.TextBox textBox_DirectVoltage;
        private System.Windows.Forms.TextBox textBox_DirectCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_SetCurrent;
        private System.Windows.Forms.TextBox textBox_setOutputCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_OpenClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Disconnect;
    }
}

