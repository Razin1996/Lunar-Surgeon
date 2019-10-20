namespace Mongol_Tori_Science_Box_New
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_clock = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_amino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_soil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_biomass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_K_O = new System.Windows.Forms.TextBox();
            this.txt_K_V = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_P_O = new System.Windows.Forms.TextBox();
            this.txt_P_V = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_N_O = new System.Windows.Forms.TextBox();
            this.txt_N_V = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txt_clock);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.txt_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_disconnect);
            this.panel1.Controls.Add(this.btn_connect);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_IP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 76);
            this.panel1.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkCyan;
            this.label22.Location = new System.Drawing.Point(814, 12);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 17);
            this.label22.TabIndex = 10;
            this.label22.Text = "Clock";
            // 
            // txt_clock
            // 
            this.txt_clock.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clock.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_clock.Location = new System.Drawing.Point(864, 10);
            this.txt_clock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_clock.Name = "txt_clock";
            this.txt_clock.Size = new System.Drawing.Size(173, 21);
            this.txt_clock.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.progressBar.Location = new System.Drawing.Point(507, 41);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(529, 18);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_status.Location = new System.Drawing.Point(117, 41);
            this.txt_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(306, 23);
            this.txt_status.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(18, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rover Status";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.Image = ((System.Drawing.Image)(resources.GetObject("btn_disconnect.Image")));
            this.btn_disconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_disconnect.Location = new System.Drawing.Point(633, 4);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(114, 24);
            this.btn_disconnect.TabIndex = 6;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connect.Location = new System.Drawing.Point(507, 5);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(98, 24);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(380, 7);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(104, 25);
            this.comboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(237, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Available COM Ports";
            // 
            // txt_IP
            // 
            this.txt_IP.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_IP.Location = new System.Drawing.Point(82, 6);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(131, 23);
            this.txt_IP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(17, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rover IP";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_amino);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(11, 104);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 100);
            this.panel3.TabIndex = 2;
            // 
            // txt_amino
            // 
            this.txt_amino.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_amino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amino.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_amino.Location = new System.Drawing.Point(56, 50);
            this.txt_amino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_amino.Name = "txt_amino";
            this.txt_amino.Size = new System.Drawing.Size(76, 23);
            this.txt_amino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(53, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amino Acid";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txt_soil);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(606, 104);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 100);
            this.panel4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(132, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "gm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_soil
            // 
            this.txt_soil.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_soil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soil.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_soil.Location = new System.Drawing.Point(56, 50);
            this.txt_soil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_soil.Name = "txt_soil";
            this.txt_soil.Size = new System.Drawing.Size(76, 23);
            this.txt_soil.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(57, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Soil Store";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txt_biomass);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(308, 104);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 100);
            this.panel5.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(133, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "gm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_biomass
            // 
            this.txt_biomass.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_biomass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_biomass.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_biomass.Location = new System.Drawing.Point(56, 50);
            this.txt_biomass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_biomass.Name = "txt_biomass";
            this.txt_biomass.Size = new System.Drawing.Size(76, 23);
            this.txt_biomass.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(61, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Biomass";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.txt_K_O);
            this.panel8.Controls.Add(this.txt_K_V);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Controls.Add(this.txt_P_O);
            this.panel8.Controls.Add(this.txt_P_V);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.txt_N_O);
            this.panel8.Controls.Add(this.txt_N_V);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(805, 104);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(257, 282);
            this.panel8.TabIndex = 6;
            // 
            // txt_K_O
            // 
            this.txt_K_O.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_K_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_K_O.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_K_O.Location = new System.Drawing.Point(166, 222);
            this.txt_K_O.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_K_O.Name = "txt_K_O";
            this.txt_K_O.Size = new System.Drawing.Size(76, 23);
            this.txt_K_O.TabIndex = 15;
            // 
            // txt_K_V
            // 
            this.txt_K_V.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_K_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_K_V.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_K_V.Location = new System.Drawing.Point(61, 222);
            this.txt_K_V.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_K_V.Name = "txt_K_V";
            this.txt_K_V.Size = new System.Drawing.Size(76, 23);
            this.txt_K_V.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkCyan;
            this.label20.Location = new System.Drawing.Point(46, 225);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "V";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkCyan;
            this.label21.Location = new System.Drawing.Point(150, 225);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 17);
            this.label21.TabIndex = 12;
            this.label21.Text = "O";
            // 
            // txt_P_O
            // 
            this.txt_P_O.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_P_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_O.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_P_O.Location = new System.Drawing.Point(166, 149);
            this.txt_P_O.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_P_O.Name = "txt_P_O";
            this.txt_P_O.Size = new System.Drawing.Size(76, 23);
            this.txt_P_O.TabIndex = 11;
            // 
            // txt_P_V
            // 
            this.txt_P_V.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_P_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_V.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_P_V.Location = new System.Drawing.Point(61, 149);
            this.txt_P_V.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_P_V.Name = "txt_P_V";
            this.txt_P_V.Size = new System.Drawing.Size(76, 23);
            this.txt_P_V.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkCyan;
            this.label18.Location = new System.Drawing.Point(46, 152);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 17);
            this.label18.TabIndex = 9;
            this.label18.Text = "V";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(150, 152);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "O";
            // 
            // txt_N_O
            // 
            this.txt_N_O.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_N_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_N_O.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_N_O.Location = new System.Drawing.Point(166, 80);
            this.txt_N_O.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_N_O.Name = "txt_N_O";
            this.txt_N_O.Size = new System.Drawing.Size(76, 23);
            this.txt_N_O.TabIndex = 7;
            // 
            // txt_N_V
            // 
            this.txt_N_V.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_N_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_N_V.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_N_V.Location = new System.Drawing.Point(61, 80);
            this.txt_N_V.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_N_V.Name = "txt_N_V";
            this.txt_N_V.Size = new System.Drawing.Size(76, 23);
            this.txt_N_V.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(46, 83);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "V";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(150, 83);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "O";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(16, 151);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "P";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(16, 228);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "K";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(16, 83);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "N";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(86, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Spectrometer";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.WindowText;
            this.chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkCyan;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.DarkCyan;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DarkCyan;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.DarkCyan;
            chartArea1.BorderColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(11, 208);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.DarkCyan;
            series1.Legend = "Legend1";
            series1.Name = "Raman";
            series1.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(780, 177);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1072, 395);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Mongol-Tori Science Box Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amino;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_soil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_biomass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_K_O;
        private System.Windows.Forms.TextBox txt_K_V;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_P_O;
        private System.Windows.Forms.TextBox txt_P_V;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_N_O;
        private System.Windows.Forms.TextBox txt_N_V;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_clock;
        private System.Windows.Forms.Timer timer;
    }
}

