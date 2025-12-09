namespace con_leds
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPortSelection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAppStatus = new System.Windows.Forms.Label();
            this.buttonTECNM = new System.Windows.Forms.Button();
            this.buttonLED3Off = new System.Windows.Forms.Button();
            this.buttonLED3On = new System.Windows.Forms.Button();
            this.buttonLED2Off = new System.Windows.Forms.Button();
            this.buttonLED2On = new System.Windows.Forms.Button();
            this.buttonLED1Off = new System.Windows.Forms.Button();
            this.buttonLED1On = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelClockRealTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPortObject = new System.IO.Ports.SerialPort(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(297, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto Final HMI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.buttonConnect);
            this.panel2.Controls.Add(this.comboBoxBaudRate);
            this.panel2.Controls.Add(this.comboBoxPortSelection);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 524);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::con_leds.Properties.Resources.ChatGPT_Image_29_nov_2025__13_03_23;
            this.pictureBox6.Location = new System.Drawing.Point(11, 344);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(123, 158);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(167, 302);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Green;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConnect.Location = new System.Drawing.Point(167, 270);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(88, 24);
            this.buttonConnect.TabIndex = 17;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(13, 301);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaudRate.TabIndex = 16;
            this.comboBoxBaudRate.Text = "9600";
            // 
            // comboBoxPortSelection
            // 
            this.comboBoxPortSelection.FormattingEnabled = true;
            this.comboBoxPortSelection.Location = new System.Drawing.Point(13, 270);
            this.comboBoxPortSelection.Name = "comboBoxPortSelection";
            this.comboBoxPortSelection.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPortSelection.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Location = new System.Drawing.Point(61, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Admin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(61, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Adair Valderrama";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::con_leds.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_291;
            this.pictureBox5.Location = new System.Drawing.Point(3, 207);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(61, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(61, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Victor Bordonave";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::con_leds.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_19_16_PM;
            this.pictureBox3.Location = new System.Drawing.Point(3, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(61, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Admin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(61, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Josue Avendaño";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::con_leds.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_07_16_PM;
            this.pictureBox4.Location = new System.Drawing.Point(3, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(61, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(61, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Andrew Contreras";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::con_leds.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_11_02_PM;
            this.pictureBox2.Location = new System.Drawing.Point(3, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(61, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salvador Villalpando";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::con_leds.Properties.Resources.WhatsApp_Image_2025_12_03_at_6_54_32_PM;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.labelAppStatus);
            this.panel3.Controls.Add(this.buttonTECNM);
            this.panel3.Controls.Add(this.buttonLED3Off);
            this.panel3.Controls.Add(this.buttonLED3On);
            this.panel3.Controls.Add(this.buttonLED2Off);
            this.panel3.Controls.Add(this.buttonLED2On);
            this.panel3.Controls.Add(this.buttonLED1Off);
            this.panel3.Controls.Add(this.buttonLED1On);
            this.panel3.Location = new System.Drawing.Point(297, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 155);
            this.panel3.TabIndex = 2;
            // 
            // labelAppStatus
            // 
            this.labelAppStatus.AutoSize = true;
            this.labelAppStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAppStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppStatus.Location = new System.Drawing.Point(352, 38);
            this.labelAppStatus.Name = "labelAppStatus";
            this.labelAppStatus.Size = new System.Drawing.Size(82, 25);
            this.labelAppStatus.TabIndex = 7;
            this.labelAppStatus.Text = "label12";
            // 
            // buttonTECNM
            // 
            this.buttonTECNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTECNM.Location = new System.Drawing.Point(357, 6);
            this.buttonTECNM.Name = "buttonTECNM";
            this.buttonTECNM.Size = new System.Drawing.Size(154, 23);
            this.buttonTECNM.TabIndex = 6;
            this.buttonTECNM.Text = "Mostrar TECNM";
            this.buttonTECNM.UseVisualStyleBackColor = true;
            // 
            // buttonLED3Off
            // 
            this.buttonLED3Off.BackColor = System.Drawing.Color.Red;
            this.buttonLED3Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLED3Off.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLED3Off.Location = new System.Drawing.Point(136, 38);
            this.buttonLED3Off.Name = "buttonLED3Off";
            this.buttonLED3Off.Size = new System.Drawing.Size(90, 23);
            this.buttonLED3Off.TabIndex = 5;
            this.buttonLED3Off.Text = "LED3 OFF";
            this.buttonLED3Off.UseVisualStyleBackColor = false;
            // 
            // buttonLED3On
            // 
            this.buttonLED3On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLED3On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLED3On.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLED3On.Location = new System.Drawing.Point(136, 8);
            this.buttonLED3On.Name = "buttonLED3On";
            this.buttonLED3On.Size = new System.Drawing.Size(90, 23);
            this.buttonLED3On.TabIndex = 4;
            this.buttonLED3On.Text = "LED3 ON";
            this.buttonLED3On.UseVisualStyleBackColor = false;
            // 
            // buttonLED2Off
            // 
            this.buttonLED2Off.BackColor = System.Drawing.Color.Red;
            this.buttonLED2Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLED2Off.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLED2Off.Location = new System.Drawing.Point(40, 111);
            this.buttonLED2Off.Name = "buttonLED2Off";
            this.buttonLED2Off.Size = new System.Drawing.Size(90, 23);
            this.buttonLED2Off.TabIndex = 3;
            this.buttonLED2Off.Text = "LED2 OFF";
            this.buttonLED2Off.UseVisualStyleBackColor = false;
            // 
            // buttonLED2On
            // 
            this.buttonLED2On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLED2On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLED2On.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLED2On.Location = new System.Drawing.Point(40, 81);
            this.buttonLED2On.Name = "buttonLED2On";
            this.buttonLED2On.Size = new System.Drawing.Size(90, 23);
            this.buttonLED2On.TabIndex = 2;
            this.buttonLED2On.Text = "LED2 ON";
            this.buttonLED2On.UseVisualStyleBackColor = false;
            // 
            // buttonLED1Off
            // 
            this.buttonLED1Off.BackColor = System.Drawing.Color.Red;
            this.buttonLED1Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLED1Off.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLED1Off.Location = new System.Drawing.Point(40, 37);
            this.buttonLED1Off.Name = "buttonLED1Off";
            this.buttonLED1Off.Size = new System.Drawing.Size(90, 23);
            this.buttonLED1Off.TabIndex = 1;
            this.buttonLED1Off.Text = "LED1 OFF";
            this.buttonLED1Off.UseVisualStyleBackColor = false;
            // 
            // buttonLED1On
            // 
            this.buttonLED1On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLED1On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLED1On.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLED1On.Location = new System.Drawing.Point(40, 7);
            this.buttonLED1On.Name = "buttonLED1On";
            this.buttonLED1On.Size = new System.Drawing.Size(90, 23);
            this.buttonLED1On.TabIndex = 0;
            this.buttonLED1On.Text = "LED1 ON";
            this.buttonLED1On.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.labelClockRealTime);
            this.panel4.Location = new System.Drawing.Point(309, 362);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 162);
            this.panel4.TabIndex = 3;
            // 
            // labelClockRealTime
            // 
            this.labelClockRealTime.AutoSize = true;
            this.labelClockRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockRealTime.ForeColor = System.Drawing.Color.Red;
            this.labelClockRealTime.Location = new System.Drawing.Point(108, 23);
            this.labelClockRealTime.Name = "labelClockRealTime";
            this.labelClockRealTime.Size = new System.Drawing.Size(347, 91);
            this.labelClockRealTime.TabIndex = 0;
            this.labelClockRealTime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxPortSelection;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLED1On;
        private System.Windows.Forms.Button buttonLED1Off;
        private System.Windows.Forms.Button buttonLED3Off;
        private System.Windows.Forms.Button buttonLED3On;
        private System.Windows.Forms.Button buttonLED2Off;
        private System.Windows.Forms.Button buttonLED2On;
        private System.Windows.Forms.Button buttonTECNM;
        private System.Windows.Forms.Label labelAppStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelClockRealTime;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPortObject;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

