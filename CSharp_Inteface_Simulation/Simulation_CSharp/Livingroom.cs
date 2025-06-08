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
    public partial class Livingroom : Form
    {
        bool status = true;
        string rcv_data;

        IFirebaseConfig config = new FirebaseConfig
        {
            //Kết nối Project của chúng ta đến Firebase
            AuthSecret = "85YE4rQJ7FwL90IRYWrskE28I33NCYSTeAWfII4p",
            BasePath = "https://fir-webapp1-b3db8-default-rtdb.firebaseio.com/",

        };
        IFirebaseClient client;
        public Livingroom()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Livingroom_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.PortName = "COM4";
            serialPort1.Open();
            client = new FireSharp.FirebaseClient(config);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rcv_data = serialPort1.ReadLine();
        }

        private void LIGHT_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                LIGHT.Text = "OPEN";
                LIGHT.BackColor = Color.Blue;
                status = false;
                serialPort1.Write("a");
            }
            else
            {
                LIGHT.Text = "CLOSE";
                LIGHT.BackColor = Color.Red;
                status = true;
                serialPort1.Write("b");
            }
        }

        private void FAN_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                FAN.Text = "OPEN";
                FAN.BackColor = Color.Blue;
                status = false;
                serialPort1.Write("c");
            }
            else
            {
                FAN.Text = "CLOSE";
                FAN.BackColor = Color.Red;
                status = true;
                serialPort1.Write("d");
            }
        }

        private void AIR_CONDITIONER_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                AIR_CONDITIONER.Text = "OPEN";
                AIR_CONDITIONER.BackColor = Color.Blue;
                status = false;
                serialPort1.Write("e");
            }
            else
            {
                AIR_CONDITIONER.Text = "CLOSE";
                AIR_CONDITIONER.BackColor = Color.Red;
                status = true;
                serialPort1.Write("f");
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Temperature");

            String temp = response1.ResultAs<String>();
            TEMP.Text = temp.ToString();

            FirebaseResponse response2 = await client.GetAsync("Humidity");

            String humid = response2.ResultAs<String>();
            HUMID.Text = humid.ToString();

        }

        private void TEMP_Click(object sender, EventArgs e)
        {

        }

        private void HUMID_Click(object sender, EventArgs e)
        {

        }
    }
}
