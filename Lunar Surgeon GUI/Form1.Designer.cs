namespace Mongol_Tori_Science_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.Gauge_soilMoist = new AGaugeApp.AGauge();
            this.Gauge_soilTemp = new AGaugeApp.AGauge();
            this.Gauge_UV = new AGaugeApp.AGauge();
            this.Gauge_light = new AGaugeApp.AGauge();
            this.Gauge_anemometer = new AGaugeApp.AGauge();
            this.Gauge_magnet = new AGaugeApp.AGauge();
            this.Gauge_airHum = new AGaugeApp.AGauge();
            this.Gauge_airTemp = new AGaugeApp.AGauge();
            this.Gauge_CO = new AGaugeApp.AGauge();
            this.Gauge_CO2 = new AGaugeApp.AGauge();
            this.Gauge_H2 = new AGaugeApp.AGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(358, 10);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(84, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available COM Ports";
            // 
            // comboBox
            // 
            this.comboBox.DisplayMember = "0";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(184, 9);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(136, 24);
            this.comboBox.TabIndex = 2;
            this.comboBox.ValueMember = "0";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(471, 12);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(99, 23);
            this.btn_disconnect.TabIndex = 3;
            this.btn_disconnect.Text = "Disconnect\r\n";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.progressBar.Location = new System.Drawing.Point(626, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(559, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Location = new System.Drawing.Point(94, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(111, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "H2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(137, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ppm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(356, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ppm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(330, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "CO2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox2.Location = new System.Drawing.Point(313, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(575, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "ppm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(552, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "CO";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox3.Location = new System.Drawing.Point(532, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 22);
            this.textBox3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(146, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "\'C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(95, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Air Temp";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox4.Location = new System.Drawing.Point(102, 446);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 22);
            this.textBox4.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(368, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(316, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Air Hum";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox5.Location = new System.Drawing.Point(322, 446);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(41, 22);
            this.textBox5.TabIndex = 22;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(667, 614);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 34);
            this.label13.TabIndex = 27;
            this.label13.Text = "Magnetic\r\n   Field";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox6.Location = new System.Drawing.Point(681, 656);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(41, 22);
            this.textBox6.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(795, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 32;
            this.label14.Tag = "";
            this.label14.Text = "km/sec.";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(740, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Anemometer";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox7.Location = new System.Drawing.Point(738, 233);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 22);
            this.textBox7.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(596, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 36;
            this.label16.Text = "lux";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.SteelBlue;
            this.label17.Location = new System.Drawing.Point(550, 404);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Light";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox8.Location = new System.Drawing.Point(517, 446);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(77, 22);
            this.textBox8.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(797, 449);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "rad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.SteelBlue;
            this.label19.Location = new System.Drawing.Point(768, 404);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "UV";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox9.Location = new System.Drawing.Point(755, 447);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 22);
            this.textBox9.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.SteelBlue;
            this.label20.Location = new System.Drawing.Point(222, 652);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 17);
            this.label20.TabIndex = 44;
            this.label20.Text = "\'C";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.SteelBlue;
            this.label21.Location = new System.Drawing.Point(171, 607);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 43;
            this.label21.Text = "Soil Temp";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox10.Location = new System.Drawing.Point(178, 649);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(41, 22);
            this.textBox10.TabIndex = 42;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.SteelBlue;
            this.label23.Location = new System.Drawing.Point(474, 652);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 17);
            this.label23.TabIndex = 52;
            this.label23.Text = "%";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.SteelBlue;
            this.label24.Location = new System.Drawing.Point(421, 607);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 17);
            this.label24.TabIndex = 51;
            this.label24.Text = "Soil Moist";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox12.Location = new System.Drawing.Point(431, 649);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(41, 22);
            this.textBox12.TabIndex = 50;
            // 
            // Gauge_soilMoist
            // 
            this.Gauge_soilMoist.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_soilMoist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_soilMoist.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilMoist.BaseArcRadius = 70;
            this.Gauge_soilMoist.BaseArcStart = 135;
            this.Gauge_soilMoist.BaseArcSweep = 270;
            this.Gauge_soilMoist.BaseArcWidth = 2;
            this.Gauge_soilMoist.Cap_Idx = ((byte)(1));
            this.Gauge_soilMoist.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_soilMoist.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_soilMoist.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_soilMoist.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_soilMoist.CapText = "pH";
            this.Gauge_soilMoist.Center = new System.Drawing.Point(100, 100);
            this.Gauge_soilMoist.Location = new System.Drawing.Point(357, 483);
            this.Gauge_soilMoist.MaxValue = 50F;
            this.Gauge_soilMoist.MinValue = 0F;
            this.Gauge_soilMoist.Name = "Gauge_soilMoist";
            this.Gauge_soilMoist.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_soilMoist.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_soilMoist.NeedleRadius = 70;
            this.Gauge_soilMoist.NeedleType = 0;
            this.Gauge_soilMoist.NeedleWidth = 2;
            this.Gauge_soilMoist.Range_Idx = ((byte)(0));
            this.Gauge_soilMoist.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_soilMoist.RangeEnabled = true;
            this.Gauge_soilMoist.RangeEndValue = 200F;
            this.Gauge_soilMoist.RangeInnerRadius = 60;
            this.Gauge_soilMoist.RangeOuterRadius = 70;
            this.Gauge_soilMoist.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_soilMoist.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_soilMoist.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_soilMoist.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_soilMoist.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_soilMoist.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_soilMoist.RangeStartValue = -100F;
            this.Gauge_soilMoist.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilMoist.ScaleLinesInterInnerRadius = 60;
            this.Gauge_soilMoist.ScaleLinesInterOuterRadius = 70;
            this.Gauge_soilMoist.ScaleLinesInterWidth = 1;
            this.Gauge_soilMoist.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilMoist.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_soilMoist.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_soilMoist.ScaleLinesMajorStepValue = 5F;
            this.Gauge_soilMoist.ScaleLinesMajorWidth = 2;
            this.Gauge_soilMoist.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilMoist.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_soilMoist.ScaleLinesMinorNumOf = 9;
            this.Gauge_soilMoist.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_soilMoist.ScaleLinesMinorWidth = 1;
            this.Gauge_soilMoist.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilMoist.ScaleNumbersFormat = null;
            this.Gauge_soilMoist.ScaleNumbersRadius = 83;
            this.Gauge_soilMoist.ScaleNumbersRotation = 0;
            this.Gauge_soilMoist.ScaleNumbersStartScaleLine = 0;
            this.Gauge_soilMoist.ScaleNumbersStepScaleLines = 1;
            this.Gauge_soilMoist.Size = new System.Drawing.Size(244, 207);
            this.Gauge_soilMoist.TabIndex = 49;
            this.Gauge_soilMoist.Tag = "";
            this.Gauge_soilMoist.Text = "Soil Moisture";
            this.Gauge_soilMoist.Value = 0F;
            // 
            // Gauge_soilTemp
            // 
            this.Gauge_soilTemp.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_soilTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_soilTemp.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilTemp.BaseArcRadius = 70;
            this.Gauge_soilTemp.BaseArcStart = 135;
            this.Gauge_soilTemp.BaseArcSweep = 270;
            this.Gauge_soilTemp.BaseArcWidth = 2;
            this.Gauge_soilTemp.Cap_Idx = ((byte)(1));
            this.Gauge_soilTemp.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_soilTemp.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_soilTemp.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_soilTemp.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_soilTemp.CapText = "pH";
            this.Gauge_soilTemp.Center = new System.Drawing.Point(100, 100);
            this.Gauge_soilTemp.Location = new System.Drawing.Point(106, 483);
            this.Gauge_soilTemp.MaxValue = 100F;
            this.Gauge_soilTemp.MinValue = -20F;
            this.Gauge_soilTemp.Name = "Gauge_soilTemp";
            this.Gauge_soilTemp.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_soilTemp.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_soilTemp.NeedleRadius = 70;
            this.Gauge_soilTemp.NeedleType = 0;
            this.Gauge_soilTemp.NeedleWidth = 2;
            this.Gauge_soilTemp.Range_Idx = ((byte)(0));
            this.Gauge_soilTemp.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_soilTemp.RangeEnabled = true;
            this.Gauge_soilTemp.RangeEndValue = 200F;
            this.Gauge_soilTemp.RangeInnerRadius = 60;
            this.Gauge_soilTemp.RangeOuterRadius = 70;
            this.Gauge_soilTemp.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_soilTemp.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_soilTemp.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_soilTemp.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_soilTemp.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_soilTemp.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_soilTemp.RangeStartValue = -100F;
            this.Gauge_soilTemp.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilTemp.ScaleLinesInterInnerRadius = 60;
            this.Gauge_soilTemp.ScaleLinesInterOuterRadius = 70;
            this.Gauge_soilTemp.ScaleLinesInterWidth = 1;
            this.Gauge_soilTemp.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilTemp.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_soilTemp.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_soilTemp.ScaleLinesMajorStepValue = 10F;
            this.Gauge_soilTemp.ScaleLinesMajorWidth = 2;
            this.Gauge_soilTemp.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilTemp.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_soilTemp.ScaleLinesMinorNumOf = 9;
            this.Gauge_soilTemp.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_soilTemp.ScaleLinesMinorWidth = 1;
            this.Gauge_soilTemp.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_soilTemp.ScaleNumbersFormat = null;
            this.Gauge_soilTemp.ScaleNumbersRadius = 83;
            this.Gauge_soilTemp.ScaleNumbersRotation = 0;
            this.Gauge_soilTemp.ScaleNumbersStartScaleLine = 0;
            this.Gauge_soilTemp.ScaleNumbersStepScaleLines = 1;
            this.Gauge_soilTemp.Size = new System.Drawing.Size(244, 207);
            this.Gauge_soilTemp.TabIndex = 41;
            this.Gauge_soilTemp.Tag = "";
            this.Gauge_soilTemp.Text = "Soil Temperature";
            this.Gauge_soilTemp.Value = 0F;
            // 
            // Gauge_UV
            // 
            this.Gauge_UV.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_UV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_UV.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_UV.BaseArcRadius = 70;
            this.Gauge_UV.BaseArcStart = 135;
            this.Gauge_UV.BaseArcSweep = 270;
            this.Gauge_UV.BaseArcWidth = 2;
            this.Gauge_UV.Cap_Idx = ((byte)(1));
            this.Gauge_UV.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_UV.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_UV.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_UV.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_UV.CapText = "pH";
            this.Gauge_UV.Center = new System.Drawing.Point(100, 100);
            this.Gauge_UV.Location = new System.Drawing.Point(684, 280);
            this.Gauge_UV.MaxValue = 11F;
            this.Gauge_UV.MinValue = 0F;
            this.Gauge_UV.Name = "Gauge_UV";
            this.Gauge_UV.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_UV.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_UV.NeedleRadius = 70;
            this.Gauge_UV.NeedleType = 0;
            this.Gauge_UV.NeedleWidth = 2;
            this.Gauge_UV.Range_Idx = ((byte)(0));
            this.Gauge_UV.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_UV.RangeEnabled = true;
            this.Gauge_UV.RangeEndValue = 200F;
            this.Gauge_UV.RangeInnerRadius = 60;
            this.Gauge_UV.RangeOuterRadius = 70;
            this.Gauge_UV.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_UV.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_UV.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_UV.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_UV.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_UV.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_UV.RangeStartValue = -100F;
            this.Gauge_UV.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_UV.ScaleLinesInterInnerRadius = 60;
            this.Gauge_UV.ScaleLinesInterOuterRadius = 70;
            this.Gauge_UV.ScaleLinesInterWidth = 1;
            this.Gauge_UV.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_UV.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_UV.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_UV.ScaleLinesMajorStepValue = 1F;
            this.Gauge_UV.ScaleLinesMajorWidth = 2;
            this.Gauge_UV.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_UV.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_UV.ScaleLinesMinorNumOf = 9;
            this.Gauge_UV.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_UV.ScaleLinesMinorWidth = 1;
            this.Gauge_UV.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_UV.ScaleNumbersFormat = null;
            this.Gauge_UV.ScaleNumbersRadius = 83;
            this.Gauge_UV.ScaleNumbersRotation = 0;
            this.Gauge_UV.ScaleNumbersStartScaleLine = 0;
            this.Gauge_UV.ScaleNumbersStepScaleLines = 1;
            this.Gauge_UV.Size = new System.Drawing.Size(244, 207);
            this.Gauge_UV.TabIndex = 37;
            this.Gauge_UV.Tag = "";
            this.Gauge_UV.Text = "UV";
            this.Gauge_UV.Value = 0F;
            // 
            // Gauge_light
            // 
            this.Gauge_light.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_light.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_light.BaseArcRadius = 70;
            this.Gauge_light.BaseArcStart = 135;
            this.Gauge_light.BaseArcSweep = 270;
            this.Gauge_light.BaseArcWidth = 2;
            this.Gauge_light.Cap_Idx = ((byte)(1));
            this.Gauge_light.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_light.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_light.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_light.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_light.CapText = "pH";
            this.Gauge_light.Center = new System.Drawing.Point(100, 100);
            this.Gauge_light.Location = new System.Drawing.Point(471, 280);
            this.Gauge_light.MaxValue = 100000F;
            this.Gauge_light.MinValue = 0F;
            this.Gauge_light.Name = "Gauge_light";
            this.Gauge_light.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_light.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_light.NeedleRadius = 70;
            this.Gauge_light.NeedleType = 0;
            this.Gauge_light.NeedleWidth = 2;
            this.Gauge_light.Range_Idx = ((byte)(0));
            this.Gauge_light.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_light.RangeEnabled = true;
            this.Gauge_light.RangeEndValue = 200F;
            this.Gauge_light.RangeInnerRadius = 60;
            this.Gauge_light.RangeOuterRadius = 70;
            this.Gauge_light.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_light.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_light.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_light.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_light.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_light.RangesStartValue = new float[] {
        0F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_light.RangeStartValue = 0F;
            this.Gauge_light.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_light.ScaleLinesInterInnerRadius = 60;
            this.Gauge_light.ScaleLinesInterOuterRadius = 70;
            this.Gauge_light.ScaleLinesInterWidth = 1;
            this.Gauge_light.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_light.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_light.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_light.ScaleLinesMajorStepValue = 10000F;
            this.Gauge_light.ScaleLinesMajorWidth = 2;
            this.Gauge_light.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_light.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_light.ScaleLinesMinorNumOf = 9;
            this.Gauge_light.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_light.ScaleLinesMinorWidth = 1;
            this.Gauge_light.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_light.ScaleNumbersFormat = null;
            this.Gauge_light.ScaleNumbersRadius = 86;
            this.Gauge_light.ScaleNumbersRotation = 0;
            this.Gauge_light.ScaleNumbersStartScaleLine = 0;
            this.Gauge_light.ScaleNumbersStepScaleLines = 1;
            this.Gauge_light.Size = new System.Drawing.Size(237, 207);
            this.Gauge_light.TabIndex = 33;
            this.Gauge_light.Tag = "";
            this.Gauge_light.Text = "Light";
            this.Gauge_light.Value = 0F;
            // 
            // Gauge_anemometer
            // 
            this.Gauge_anemometer.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_anemometer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_anemometer.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_anemometer.BaseArcRadius = 70;
            this.Gauge_anemometer.BaseArcStart = 135;
            this.Gauge_anemometer.BaseArcSweep = 270;
            this.Gauge_anemometer.BaseArcWidth = 2;
            this.Gauge_anemometer.Cap_Idx = ((byte)(1));
            this.Gauge_anemometer.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_anemometer.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_anemometer.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_anemometer.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_anemometer.CapText = "pH";
            this.Gauge_anemometer.Center = new System.Drawing.Point(100, 100);
            this.Gauge_anemometer.Location = new System.Drawing.Point(684, 67);
            this.Gauge_anemometer.MaxValue = 300F;
            this.Gauge_anemometer.MinValue = 0F;
            this.Gauge_anemometer.Name = "Gauge_anemometer";
            this.Gauge_anemometer.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_anemometer.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_anemometer.NeedleRadius = 70;
            this.Gauge_anemometer.NeedleType = 0;
            this.Gauge_anemometer.NeedleWidth = 2;
            this.Gauge_anemometer.Range_Idx = ((byte)(0));
            this.Gauge_anemometer.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_anemometer.RangeEnabled = true;
            this.Gauge_anemometer.RangeEndValue = 200F;
            this.Gauge_anemometer.RangeInnerRadius = 60;
            this.Gauge_anemometer.RangeOuterRadius = 70;
            this.Gauge_anemometer.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_anemometer.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_anemometer.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_anemometer.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_anemometer.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_anemometer.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_anemometer.RangeStartValue = -100F;
            this.Gauge_anemometer.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_anemometer.ScaleLinesInterInnerRadius = 60;
            this.Gauge_anemometer.ScaleLinesInterOuterRadius = 70;
            this.Gauge_anemometer.ScaleLinesInterWidth = 1;
            this.Gauge_anemometer.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_anemometer.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_anemometer.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_anemometer.ScaleLinesMajorStepValue = 20F;
            this.Gauge_anemometer.ScaleLinesMajorWidth = 2;
            this.Gauge_anemometer.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_anemometer.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_anemometer.ScaleLinesMinorNumOf = 9;
            this.Gauge_anemometer.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_anemometer.ScaleLinesMinorWidth = 1;
            this.Gauge_anemometer.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_anemometer.ScaleNumbersFormat = null;
            this.Gauge_anemometer.ScaleNumbersRadius = 83;
            this.Gauge_anemometer.ScaleNumbersRotation = 0;
            this.Gauge_anemometer.ScaleNumbersStartScaleLine = 0;
            this.Gauge_anemometer.ScaleNumbersStepScaleLines = 1;
            this.Gauge_anemometer.Size = new System.Drawing.Size(244, 219);
            this.Gauge_anemometer.TabIndex = 29;
            this.Gauge_anemometer.Tag = "";
            this.Gauge_anemometer.Text = "Anemometer";
            this.Gauge_anemometer.Value = 0F;
            // 
            // Gauge_magnet
            // 
            this.Gauge_magnet.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_magnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_magnet.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_magnet.BaseArcRadius = 70;
            this.Gauge_magnet.BaseArcStart = 135;
            this.Gauge_magnet.BaseArcSweep = 270;
            this.Gauge_magnet.BaseArcWidth = 2;
            this.Gauge_magnet.Cap_Idx = ((byte)(1));
            this.Gauge_magnet.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_magnet.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_magnet.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_magnet.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.Gauge_magnet.CapText = "";
            this.Gauge_magnet.Center = new System.Drawing.Point(100, 100);
            this.Gauge_magnet.Location = new System.Drawing.Point(598, 483);
            this.Gauge_magnet.MaxValue = 1F;
            this.Gauge_magnet.MinValue = 0F;
            this.Gauge_magnet.Name = "Gauge_magnet";
            this.Gauge_magnet.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_magnet.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_magnet.NeedleRadius = 70;
            this.Gauge_magnet.NeedleType = 0;
            this.Gauge_magnet.NeedleWidth = 2;
            this.Gauge_magnet.Range_Idx = ((byte)(2));
            this.Gauge_magnet.RangeColor = System.Drawing.Color.Transparent;
            this.Gauge_magnet.RangeEnabled = false;
            this.Gauge_magnet.RangeEndValue = 300F;
            this.Gauge_magnet.RangeInnerRadius = 70;
            this.Gauge_magnet.RangeOuterRadius = 80;
            this.Gauge_magnet.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_magnet.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.Gauge_magnet.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_magnet.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_magnet.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_magnet.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_magnet.RangeStartValue = 200F;
            this.Gauge_magnet.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_magnet.ScaleLinesInterInnerRadius = 60;
            this.Gauge_magnet.ScaleLinesInterOuterRadius = 70;
            this.Gauge_magnet.ScaleLinesInterWidth = 1;
            this.Gauge_magnet.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_magnet.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_magnet.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_magnet.ScaleLinesMajorStepValue = 1F;
            this.Gauge_magnet.ScaleLinesMajorWidth = 2;
            this.Gauge_magnet.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_magnet.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_magnet.ScaleLinesMinorNumOf = 0;
            this.Gauge_magnet.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_magnet.ScaleLinesMinorWidth = 1;
            this.Gauge_magnet.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_magnet.ScaleNumbersFormat = null;
            this.Gauge_magnet.ScaleNumbersRadius = 83;
            this.Gauge_magnet.ScaleNumbersRotation = 0;
            this.Gauge_magnet.ScaleNumbersStartScaleLine = 0;
            this.Gauge_magnet.ScaleNumbersStepScaleLines = 1;
            this.Gauge_magnet.Size = new System.Drawing.Size(244, 207);
            this.Gauge_magnet.TabIndex = 1;
            this.Gauge_magnet.Tag = "";
            this.Gauge_magnet.Text = "Magnetic Field";
            this.Gauge_magnet.Value = 0F;
            this.Gauge_magnet.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.Gauge_magnet_ValueInRangeChanged);
            // 
            // Gauge_airHum
            // 
            this.Gauge_airHum.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_airHum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_airHum.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airHum.BaseArcRadius = 70;
            this.Gauge_airHum.BaseArcStart = 135;
            this.Gauge_airHum.BaseArcSweep = 270;
            this.Gauge_airHum.BaseArcWidth = 2;
            this.Gauge_airHum.Cap_Idx = ((byte)(1));
            this.Gauge_airHum.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_airHum.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_airHum.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_airHum.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_airHum.CapText = "pH";
            this.Gauge_airHum.Center = new System.Drawing.Point(100, 100);
            this.Gauge_airHum.Location = new System.Drawing.Point(246, 280);
            this.Gauge_airHum.MaxValue = 100F;
            this.Gauge_airHum.MinValue = 0F;
            this.Gauge_airHum.Name = "Gauge_airHum";
            this.Gauge_airHum.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_airHum.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_airHum.NeedleRadius = 70;
            this.Gauge_airHum.NeedleType = 0;
            this.Gauge_airHum.NeedleWidth = 2;
            this.Gauge_airHum.Range_Idx = ((byte)(0));
            this.Gauge_airHum.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_airHum.RangeEnabled = true;
            this.Gauge_airHum.RangeEndValue = 200F;
            this.Gauge_airHum.RangeInnerRadius = 60;
            this.Gauge_airHum.RangeOuterRadius = 70;
            this.Gauge_airHum.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_airHum.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_airHum.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_airHum.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_airHum.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_airHum.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_airHum.RangeStartValue = -100F;
            this.Gauge_airHum.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airHum.ScaleLinesInterInnerRadius = 60;
            this.Gauge_airHum.ScaleLinesInterOuterRadius = 70;
            this.Gauge_airHum.ScaleLinesInterWidth = 1;
            this.Gauge_airHum.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airHum.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_airHum.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_airHum.ScaleLinesMajorStepValue = 10F;
            this.Gauge_airHum.ScaleLinesMajorWidth = 2;
            this.Gauge_airHum.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airHum.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_airHum.ScaleLinesMinorNumOf = 9;
            this.Gauge_airHum.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_airHum.ScaleLinesMinorWidth = 1;
            this.Gauge_airHum.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airHum.ScaleNumbersFormat = null;
            this.Gauge_airHum.ScaleNumbersRadius = 83;
            this.Gauge_airHum.ScaleNumbersRotation = 0;
            this.Gauge_airHum.ScaleNumbersStartScaleLine = 0;
            this.Gauge_airHum.ScaleNumbersStepScaleLines = 1;
            this.Gauge_airHum.Size = new System.Drawing.Size(244, 207);
            this.Gauge_airHum.TabIndex = 21;
            this.Gauge_airHum.Tag = "";
            this.Gauge_airHum.Text = "Air Humidity";
            this.Gauge_airHum.Value = 0F;
            this.Gauge_airHum.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.Gauge_airHum_ValueInRangeChanged);
            // 
            // Gauge_airTemp
            // 
            this.Gauge_airTemp.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_airTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_airTemp.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airTemp.BaseArcRadius = 70;
            this.Gauge_airTemp.BaseArcStart = 135;
            this.Gauge_airTemp.BaseArcSweep = 270;
            this.Gauge_airTemp.BaseArcWidth = 2;
            this.Gauge_airTemp.Cap_Idx = ((byte)(1));
            this.Gauge_airTemp.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_airTemp.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_airTemp.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_airTemp.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_airTemp.CapText = "pH";
            this.Gauge_airTemp.Center = new System.Drawing.Point(100, 100);
            this.Gauge_airTemp.Location = new System.Drawing.Point(27, 280);
            this.Gauge_airTemp.MaxValue = 100F;
            this.Gauge_airTemp.MinValue = -50F;
            this.Gauge_airTemp.Name = "Gauge_airTemp";
            this.Gauge_airTemp.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_airTemp.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_airTemp.NeedleRadius = 70;
            this.Gauge_airTemp.NeedleType = 0;
            this.Gauge_airTemp.NeedleWidth = 2;
            this.Gauge_airTemp.Range_Idx = ((byte)(0));
            this.Gauge_airTemp.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_airTemp.RangeEnabled = true;
            this.Gauge_airTemp.RangeEndValue = 200F;
            this.Gauge_airTemp.RangeInnerRadius = 60;
            this.Gauge_airTemp.RangeOuterRadius = 70;
            this.Gauge_airTemp.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_airTemp.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_airTemp.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_airTemp.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_airTemp.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_airTemp.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_airTemp.RangeStartValue = -100F;
            this.Gauge_airTemp.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airTemp.ScaleLinesInterInnerRadius = 60;
            this.Gauge_airTemp.ScaleLinesInterOuterRadius = 70;
            this.Gauge_airTemp.ScaleLinesInterWidth = 1;
            this.Gauge_airTemp.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airTemp.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_airTemp.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_airTemp.ScaleLinesMajorStepValue = 10F;
            this.Gauge_airTemp.ScaleLinesMajorWidth = 2;
            this.Gauge_airTemp.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airTemp.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_airTemp.ScaleLinesMinorNumOf = 9;
            this.Gauge_airTemp.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_airTemp.ScaleLinesMinorWidth = 1;
            this.Gauge_airTemp.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_airTemp.ScaleNumbersFormat = null;
            this.Gauge_airTemp.ScaleNumbersRadius = 83;
            this.Gauge_airTemp.ScaleNumbersRotation = 0;
            this.Gauge_airTemp.ScaleNumbersStartScaleLine = 0;
            this.Gauge_airTemp.ScaleNumbersStepScaleLines = 1;
            this.Gauge_airTemp.Size = new System.Drawing.Size(244, 207);
            this.Gauge_airTemp.TabIndex = 17;
            this.Gauge_airTemp.Tag = "";
            this.Gauge_airTemp.Text = "Air Temperature";
            this.Gauge_airTemp.Value = 0F;
            // 
            // Gauge_CO
            // 
            this.Gauge_CO.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_CO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_CO.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO.BaseArcRadius = 70;
            this.Gauge_CO.BaseArcStart = 135;
            this.Gauge_CO.BaseArcSweep = 270;
            this.Gauge_CO.BaseArcWidth = 2;
            this.Gauge_CO.Cap_Idx = ((byte)(1));
            this.Gauge_CO.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_CO.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_CO.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_CO.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_CO.CapText = "pH";
            this.Gauge_CO.Center = new System.Drawing.Point(100, 100);
            this.Gauge_CO.Location = new System.Drawing.Point(468, 67);
            this.Gauge_CO.MaxValue = 400F;
            this.Gauge_CO.MinValue = 0F;
            this.Gauge_CO.Name = "Gauge_CO";
            this.Gauge_CO.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_CO.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_CO.NeedleRadius = 70;
            this.Gauge_CO.NeedleType = 0;
            this.Gauge_CO.NeedleWidth = 2;
            this.Gauge_CO.Range_Idx = ((byte)(0));
            this.Gauge_CO.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_CO.RangeEnabled = true;
            this.Gauge_CO.RangeEndValue = 200F;
            this.Gauge_CO.RangeInnerRadius = 60;
            this.Gauge_CO.RangeOuterRadius = 70;
            this.Gauge_CO.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_CO.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_CO.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_CO.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_CO.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_CO.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_CO.RangeStartValue = -100F;
            this.Gauge_CO.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO.ScaleLinesInterInnerRadius = 60;
            this.Gauge_CO.ScaleLinesInterOuterRadius = 70;
            this.Gauge_CO.ScaleLinesInterWidth = 1;
            this.Gauge_CO.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_CO.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_CO.ScaleLinesMajorStepValue = 50F;
            this.Gauge_CO.ScaleLinesMajorWidth = 2;
            this.Gauge_CO.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_CO.ScaleLinesMinorNumOf = 9;
            this.Gauge_CO.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_CO.ScaleLinesMinorWidth = 1;
            this.Gauge_CO.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO.ScaleNumbersFormat = null;
            this.Gauge_CO.ScaleNumbersRadius = 83;
            this.Gauge_CO.ScaleNumbersRotation = 0;
            this.Gauge_CO.ScaleNumbersStartScaleLine = 0;
            this.Gauge_CO.ScaleNumbersStepScaleLines = 1;
            this.Gauge_CO.Size = new System.Drawing.Size(244, 207);
            this.Gauge_CO.TabIndex = 13;
            this.Gauge_CO.Tag = "";
            this.Gauge_CO.Text = "CO";
            this.Gauge_CO.Value = 0F;
            // 
            // Gauge_CO2
            // 
            this.Gauge_CO2.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_CO2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_CO2.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO2.BaseArcRadius = 70;
            this.Gauge_CO2.BaseArcStart = 135;
            this.Gauge_CO2.BaseArcSweep = 270;
            this.Gauge_CO2.BaseArcWidth = 2;
            this.Gauge_CO2.Cap_Idx = ((byte)(1));
            this.Gauge_CO2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_CO2.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_CO2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_CO2.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_CO2.CapText = "pH";
            this.Gauge_CO2.Center = new System.Drawing.Point(100, 100);
            this.Gauge_CO2.Location = new System.Drawing.Point(246, 67);
            this.Gauge_CO2.MaxValue = 400F;
            this.Gauge_CO2.MinValue = 0F;
            this.Gauge_CO2.Name = "Gauge_CO2";
            this.Gauge_CO2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_CO2.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_CO2.NeedleRadius = 70;
            this.Gauge_CO2.NeedleType = 0;
            this.Gauge_CO2.NeedleWidth = 2;
            this.Gauge_CO2.Range_Idx = ((byte)(0));
            this.Gauge_CO2.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_CO2.RangeEnabled = true;
            this.Gauge_CO2.RangeEndValue = 200F;
            this.Gauge_CO2.RangeInnerRadius = 60;
            this.Gauge_CO2.RangeOuterRadius = 70;
            this.Gauge_CO2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_CO2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_CO2.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_CO2.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_CO2.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_CO2.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_CO2.RangeStartValue = -100F;
            this.Gauge_CO2.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO2.ScaleLinesInterInnerRadius = 60;
            this.Gauge_CO2.ScaleLinesInterOuterRadius = 70;
            this.Gauge_CO2.ScaleLinesInterWidth = 1;
            this.Gauge_CO2.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO2.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_CO2.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_CO2.ScaleLinesMajorStepValue = 50F;
            this.Gauge_CO2.ScaleLinesMajorWidth = 2;
            this.Gauge_CO2.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO2.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_CO2.ScaleLinesMinorNumOf = 9;
            this.Gauge_CO2.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_CO2.ScaleLinesMinorWidth = 1;
            this.Gauge_CO2.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_CO2.ScaleNumbersFormat = null;
            this.Gauge_CO2.ScaleNumbersRadius = 83;
            this.Gauge_CO2.ScaleNumbersRotation = 0;
            this.Gauge_CO2.ScaleNumbersStartScaleLine = 0;
            this.Gauge_CO2.ScaleNumbersStepScaleLines = 1;
            this.Gauge_CO2.Size = new System.Drawing.Size(244, 207);
            this.Gauge_CO2.TabIndex = 9;
            this.Gauge_CO2.Tag = "";
            this.Gauge_CO2.Text = "CO2";
            this.Gauge_CO2.Value = 0F;
            this.Gauge_CO2.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.Gauge_CO2_ValueInRangeChanged);
            // 
            // Gauge_H2
            // 
            this.Gauge_H2.BackColor = System.Drawing.SystemColors.MenuText;
            this.Gauge_H2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gauge_H2.BaseArcColor = System.Drawing.Color.SteelBlue;
            this.Gauge_H2.BaseArcRadius = 70;
            this.Gauge_H2.BaseArcStart = 135;
            this.Gauge_H2.BaseArcSweep = 270;
            this.Gauge_H2.BaseArcWidth = 2;
            this.Gauge_H2.Cap_Idx = ((byte)(1));
            this.Gauge_H2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge_H2.CapPosition = new System.Drawing.Point(10, 10);
            this.Gauge_H2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge_H2.CapsText = new string[] {
        "",
        "pH",
        "",
        "",
        ""};
            this.Gauge_H2.CapText = "pH";
            this.Gauge_H2.Center = new System.Drawing.Point(100, 100);
            this.Gauge_H2.Location = new System.Drawing.Point(27, 67);
            this.Gauge_H2.MaxValue = 400F;
            this.Gauge_H2.MinValue = 0F;
            this.Gauge_H2.Name = "Gauge_H2";
            this.Gauge_H2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Magenta;
            this.Gauge_H2.NeedleColor2 = System.Drawing.Color.SteelBlue;
            this.Gauge_H2.NeedleRadius = 70;
            this.Gauge_H2.NeedleType = 0;
            this.Gauge_H2.NeedleWidth = 2;
            this.Gauge_H2.Range_Idx = ((byte)(0));
            this.Gauge_H2.RangeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gauge_H2.RangeEnabled = true;
            this.Gauge_H2.RangeEndValue = 200F;
            this.Gauge_H2.RangeInnerRadius = 60;
            this.Gauge_H2.RangeOuterRadius = 70;
            this.Gauge_H2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.SystemColors.ActiveCaptionText,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge_H2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.Gauge_H2.RangesEndValue = new float[] {
        200F,
        400F,
        300F,
        0F,
        0F};
            this.Gauge_H2.RangesInnerRadius = new int[] {
        60,
        70,
        70,
        70,
        70};
            this.Gauge_H2.RangesOuterRadius = new int[] {
        70,
        80,
        80,
        80,
        80};
            this.Gauge_H2.RangesStartValue = new float[] {
        -100F,
        300F,
        200F,
        0F,
        0F};
            this.Gauge_H2.RangeStartValue = -100F;
            this.Gauge_H2.ScaleLinesInterColor = System.Drawing.Color.SteelBlue;
            this.Gauge_H2.ScaleLinesInterInnerRadius = 60;
            this.Gauge_H2.ScaleLinesInterOuterRadius = 70;
            this.Gauge_H2.ScaleLinesInterWidth = 1;
            this.Gauge_H2.ScaleLinesMajorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_H2.ScaleLinesMajorInnerRadius = 60;
            this.Gauge_H2.ScaleLinesMajorOuterRadius = 70;
            this.Gauge_H2.ScaleLinesMajorStepValue = 50F;
            this.Gauge_H2.ScaleLinesMajorWidth = 2;
            this.Gauge_H2.ScaleLinesMinorColor = System.Drawing.Color.SteelBlue;
            this.Gauge_H2.ScaleLinesMinorInnerRadius = 65;
            this.Gauge_H2.ScaleLinesMinorNumOf = 9;
            this.Gauge_H2.ScaleLinesMinorOuterRadius = 70;
            this.Gauge_H2.ScaleLinesMinorWidth = 1;
            this.Gauge_H2.ScaleNumbersColor = System.Drawing.Color.SteelBlue;
            this.Gauge_H2.ScaleNumbersFormat = null;
            this.Gauge_H2.ScaleNumbersRadius = 83;
            this.Gauge_H2.ScaleNumbersRotation = 0;
            this.Gauge_H2.ScaleNumbersStartScaleLine = 0;
            this.Gauge_H2.ScaleNumbersStepScaleLines = 1;
            this.Gauge_H2.Size = new System.Drawing.Size(244, 207);
            this.Gauge_H2.TabIndex = 4;
            this.Gauge_H2.Tag = "";
            this.Gauge_H2.Text = "H2O";
            this.Gauge_H2.Value = 0F;
            this.Gauge_H2.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge1_ValueInRangeChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(883, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 464);
            this.panel1.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1361, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.Gauge_soilMoist);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.Gauge_soilTemp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Gauge_UV);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Gauge_light);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Gauge_anemometer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Gauge_magnet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Gauge_airHum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Gauge_airTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Gauge_CO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Gauge_CO2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gauge_H2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRACU Mongol-Tori Sensor Box GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btn_disconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private AGaugeApp.AGauge Gauge_H2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private AGaugeApp.AGauge Gauge_CO2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private AGaugeApp.AGauge Gauge_CO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private AGaugeApp.AGauge Gauge_airTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private AGaugeApp.AGauge Gauge_airHum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private AGaugeApp.AGauge Gauge_magnet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private AGaugeApp.AGauge Gauge_anemometer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox8;
        private AGaugeApp.AGauge Gauge_light;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox9;
        private AGaugeApp.AGauge Gauge_UV;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox10;
        private AGaugeApp.AGauge Gauge_soilTemp;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox12;
        private AGaugeApp.AGauge Gauge_soilMoist;
        private System.Windows.Forms.Panel panel1;
    }
}

