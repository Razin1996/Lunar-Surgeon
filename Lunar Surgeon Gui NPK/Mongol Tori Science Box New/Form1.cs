using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Mongol_Tori_Science_Box_New
{
    public partial class Form1 : Form
    {
        public DateTime datetime;
        public string data;
        public string datum;
        public string amino;
        public string biomass;
        public string soil;
        public string N_V;
        public string N_O;
        public string P_V;
        public string P_O;
        public string K_V;
        public string K_O;
        private SerialPort myPort;

        public Form1()
        {
            this.InitializeComponent();
            this.availableCOMPorts();
        }

        private void availableCOMPorts()
        {
            this.comboBox.Items.AddRange((object[])SerialPort.GetPortNames());
        }

        public void myPort_DataReceived(object sender, EventArgs e)
        {
            this.datum = myPort.ReadLine();
            string[] strArray = datum.Split(new string[3]
            {
        ",",
        "/",
        ";"
            }, StringSplitOptions.RemoveEmptyEntries);
            this.amino = strArray[0];
            this.biomass = strArray[1];
            this.soil = strArray[2];
            this.N_V = strArray[3];
            this.N_O = strArray[4];
            this.P_V = strArray[5];
            this.P_O = strArray[6];
            this.K_V = strArray[7];
            this.K_O = strArray[8];
            this.Invoke((Delegate)new EventHandler(displaydata_event));
            StreamWriter sw = new StreamWriter("D:\\Mongol Tori\\MT-19\\Mongol Tori Science Box New\\Sensor Value.txt");
            sw.WriteLine(strArray);
        }

        public void displaydata_event(object sender, EventArgs e)
        {
            this.txt_amino.Text = this.amino;
            this.txt_biomass.Text = this.biomass;
            this.txt_soil.Text = this.soil;
            this.txt_N_V.Text = this.N_V;
            this.txt_N_O.Text = this.N_O;
            this.txt_P_V.Text = this.P_V;
            this.txt_P_O.Text = this.P_O;
            this.txt_K_V.Text = this.K_V;
            this.txt_K_O.Text = this.K_O;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (this.comboBox.Text == "")
            {
                this.txt_status.Text = "Please Select COM Port";
            }
            else
            {
                try
                {
                    //myPort.PortName = comboBox.Text;
                    //myPort.Open();
                    //this.progressBar.Value = 100;
                    //this.myPort.DataReceived += new SerialDataReceivedEventHandler(this.myPort_DataReceived);
                    this.myPort = new SerialPort();
                    this.myPort.PortName = this.comboBox.Text;
                    this.myPort.BaudRate = int.Parse("9600");
                    this.myPort.Open();
                    this.myPort.Parity = Parity.None;
                    this.myPort.StopBits = StopBits.One;
                    this.myPort.DataBits = 8;
                    this.progressBar.Visible = true;
                    this.progressBar.Value = 100;
                    this.txt_status.Text = "Connected to " + this.comboBox.Text;
                    this.myPort.DataReceived += new SerialDataReceivedEventHandler(this.myPort_DataReceived);
                    this.txt_IP.Text = Form1.GetLocalIPAddress();
                }
                catch (UnauthorizedAccessException ex)
                {
                    this.txt_status.Text = "Unauthorised Access";
                }
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (this.myPort.IsOpen)
            {
                this.myPort.Close();
                this.progressBar.Value = 0;
                this.txt_status.Text = this.comboBox.Text + " Disconnected";
                this.progressBar.Visible = false;
            }
            this.myPort.Dispose();
        }

        public static string GetLocalIPAddress()
        {
            foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    return address.ToString();
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            String clock = DateTime.Now.ToLongTimeString();
            this.txt_clock.Text = clock;
        }

        private void btn_water_Click(object sender, EventArgs e)
        {
            myPort.Write("a");
        }


    }
}
