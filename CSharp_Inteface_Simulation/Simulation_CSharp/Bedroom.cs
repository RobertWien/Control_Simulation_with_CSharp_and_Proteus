using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_CSharp
{
    public partial class Bedroom : Form
    {
        bool status_led = true;
        bool status_fan = true;
        bool status_air = true;
        string rcv_data;

        IFirebaseConfig config = new FirebaseConfig
        {
            //Kết nối Project của chúng ta đến Firebase
            AuthSecret = "85YE4rQJ7FwL90IRYWrskE28I33NCYSTeAWfII4p",
            BasePath = "https://fir-webapp1-b3db8-default-rtdb.firebaseio.com/",

        };
        IFirebaseClient client;
        public Bedroom()
        {
            InitializeComponent();
        }

        private void FAN_Click(object sender, EventArgs e)
        {
            if (status_fan == true)
            {
                FAN.Text = "OPEN";
                FAN.BackColor = Color.Blue;
                status_fan = false;
                serialPort1.Write("c");
                comboBox1.Enabled = true;

                if (comboBox1.Text == "1")
                {
                    serialPort1.Write("1");
                }

                if (comboBox1.Text == "2")
                {
                    serialPort1.Write("2");
                }

                if (comboBox1.Text == "3")
                {
                    serialPort1.Write("3");
                }

                if (comboBox1.Text == "4")
                {
                    serialPort1.Write("4");
                }

                if (comboBox1.Text == "5")
                {
                    serialPort1.Write("5");
                }

                if (comboBox1.Text == "6")
                {
                    serialPort1.Write("6");
                }

                if (comboBox1.Text == "7")
                {
                    serialPort1.Write("7");
                }

                if (comboBox1.Text == "8")
                {
                    serialPort1.Write("8");
                }

                if (comboBox1.Text == "9")
                {
                    serialPort1.Write("9");
                }

                if (comboBox1.Text == "10")
                {
                    serialPort1.Write("z");
                }
            }
            else
            {
                FAN.Text = "CLOSE";
                FAN.BackColor = Color.Red;
                status_fan = true;
                serialPort1.Write("d");
                comboBox1.Enabled = false;
            }
        }

        private void LIGHT_Click(object sender, EventArgs e)
        {
            if (status_led == true)
            {
                LIGHT.Text = "OPEN";
                LIGHT.BackColor = Color.Blue;
                status_led = false;
                serialPort1.Write("a");
            }
            else
            {
                LIGHT.Text = "CLOSE";
                LIGHT.BackColor = Color.Red;
                status_led = true;
                serialPort1.Write("b");
            }
        }

        private void TEMP_Click(object sender, EventArgs e)
        {

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Temperature");

            String temp = response1.ResultAs<String>();
            TEMP.Text = temp.ToString();

            FirebaseResponse response2 = await client.GetAsync("Humidity");

            String humid = response2.ResultAs<String>();
            HUMID.Text = humid.ToString();

            FirebaseResponse response3 = await client.GetAsync("Unit");

            String unit = response3.ResultAs<String>();


            // serialPort1.Write("s");

            if (comboBox1.Enabled = true)
                label8.Text = comboBox1.Text;
            else label8.Text = unit.ToString();     
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Bedroom_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.PortName = "COM4";
            serialPort1.Open();
            client = new FireSharp.FirebaseClient(config);
            comboBox1.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            rcv_data = serialPort1.ReadLine();
            
        }

        private void AIR_CONDITIONER_Click(object sender, EventArgs e)
        {
            if (status_air == true)
            {
                AIR_CONDITIONER.Text = "OPEN";
                AIR_CONDITIONER.BackColor = Color.Blue;
                status_air = false;
                serialPort1.Write("e");
            }
            else
            {
                AIR_CONDITIONER.Text = "CLOSE";
                AIR_CONDITIONER.BackColor = Color.Red;
                status_air = true;
                serialPort1.Write("f");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
         
            if (cb.SelectedIndex.ToString() == "10")
            {
                serialPort1.Write("z");
                MessageBox.Show("Change Unit");
            }
            if (cb.SelectedIndex.ToString() == "1")
            {
                serialPort1.Write("1");
                MessageBox.Show("Change Unit");
            }

            if (cb.SelectedIndex.ToString() == "2")
            {
                serialPort1.Write("2");
                MessageBox.Show("Change Unit");
            }

            if (cb.SelectedIndex.ToString() == "3")
            {
                serialPort1.Write("3");
                MessageBox.Show("Change Unit");
            }

            if (cb.SelectedIndex.ToString() == "4")
            {
                serialPort1.Write("4");
                MessageBox.Show("Change Unit");
            }

            if (cb.SelectedIndex.ToString() == "5")
            {
                serialPort1.Write("5");
                MessageBox.Show("Change Unit");
            }

            if (cb.SelectedIndex.ToString() == "6")
            {
                serialPort1.Write("6");
                MessageBox.Show("Change Unit");
            }
            if (cb.SelectedIndex.ToString() == "7")
            {
                serialPort1.Write("7");
                MessageBox.Show("Change Unit");
            }
            if (cb.SelectedIndex.ToString() == "8")
            {
                serialPort1.Write("8");
                MessageBox.Show("Change Unit");
            }
            if (cb.SelectedIndex.ToString() == "9")
            {
                serialPort1.Write("9");
                MessageBox.Show("Change Unit");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
