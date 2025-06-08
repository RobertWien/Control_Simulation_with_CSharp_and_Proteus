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
    public partial class Door : Form
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

        public Door()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void CONTROL_DOOR_Click(object sender, EventArgs e)
        {
           if (status == true)
            {
                CONTROL_DOOR.Text = "OPEN";
                CONTROL_DOOR.BackColor = Color.Blue;
                status = false;
                serialPort1.Write("a");         
            } else 
            {
                CONTROL_DOOR.Text = "CLOSE";
                CONTROL_DOOR.BackColor = Color.Red;
                status = true;
                serialPort1.Write("b");
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Humidity");

            String humid = response1.ResultAs<String>();
            label3.Text = humid.ToString();

           
        }
    }
}
