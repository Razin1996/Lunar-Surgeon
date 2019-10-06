using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mongol_Tori_Science_GUI
{
    public partial class Form1 : Form
    {
        public string data;
        public string datum;
        public string h2;
        public string co2;
        public string co;
        public string anemometer;
        public string air_temp;
        public string air_hum;
        public string light;
        public string uv;
        public string soil_temp;
        public string soil_moist;
        public string mag;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox.Items.AddRange((object[])SerialPort.GetPortNames());
            btn_disconnect.Enabled = false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;
            btn_disconnect.Enabled = true;
            try
            {
                serialPort1.PortName = comboBox.Text;
                serialPort1.Open();
                this.progressBar.Value = 100;
                this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = true;
            btn_disconnect.Enabled = false;
            try
            {
                serialPort1.Close();
                this.progressBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SerialPort_DataReceived(object sender, EventArgs e)
        {
            Form1 form1 = this;
            form1.datum = form1.serialPort1.ReadLine();
            string[] strArray = form1.datum.Split(new string[3]
            {
                ":",
                "/",
                ";"
            }, StringSplitOptions.RemoveEmptyEntries);
            form1.h2 = strArray[0];
            form1.co2 = strArray[1];
            form1.co = strArray[2];
            form1.anemometer = strArray[3];
            form1.air_temp = strArray[4];
            form1.air_hum = strArray[5];
            form1.light = strArray[6];
            form1.uv = strArray[7];
            form1.soil_temp = strArray[8];
            form1.soil_moist = strArray[9];
            form1.mag = strArray[10];
            form1.Invoke((Delegate)new EventHandler(form1.displaydata_event));
        }

        public void displaydata_event(object sender, EventArgs e)
        {
            textBox1.Text = h2;
            textBox2.Text = co2;
            textBox3.Text = co;
            textBox4.Text = air_temp;
            textBox5.Text = air_hum;
            textBox6.Text = mag;
            textBox7.Text = anemometer;
            textBox8.Text = light;
            textBox9.Text = uv;
            textBox10.Text = soil_temp;
            textBox12.Text = soil_moist;

            float result1;
            if (float.TryParse(h2, out result1))
            {
                Gauge_H2.Value = result1;
            }

            float result2;
            if (float.TryParse(co2, out result2))
            {
                this.Gauge_CO2.Value = result2;
            }

            float result3;
            if (float.TryParse(co, out result3))
            {
                this.Gauge_CO.Value = result3;
            }

            float result4;
            if (float.TryParse(anemometer, out result4))
            {
                this.Gauge_anemometer.Value = result4;
            }

            float result5;
            if (float.TryParse(air_temp, out result5))
            {
                this.Gauge_airTemp.Value = result5;
            }

            float result6;
            if (!float.TryParse(air_hum, out result6))
            {
                this.Gauge_airHum.Value = result6;
            }

            float result7;
            if (!float.TryParse(light, out result7))
            {
                this.Gauge_light.Value = result7;
            }

            float result8;
            if (!float.TryParse(uv, out result8))
            {
                this.Gauge_UV.Value = result8;
            }

            float result9;
            if (!float.TryParse(soil_temp, out result9))
            {
                this.Gauge_soilTemp.Value = result9;
            }

            float result10;
            if (!float.TryParse(soil_moist, out result10))
            {
                this.Gauge_soilMoist.Value = result10;
            }

            float result11;
            if (!float.TryParse(mag, out result11))
            {
                this.Gauge_magnet.Value = result11;
            }
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void Gauge_magnet_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void Gauge_airHum_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gauge_CO2_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
