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
    public partial class Kitchen : Form
    {

        bool status_led = true;
        bool status_line = true;
        private string rcv_data;

        IFirebaseConfig config = new FirebaseConfig
        {
            //Kết nối Project của chúng ta đến Firebase
            AuthSecret = "ISol1Gs2IzXP7iOfPrS5X4FWNthnxyBsfq86ilmH",
            BasePath = "https://fir-webapp2-18277-default-rtdb.firebaseio.com/",

        };
        IFirebaseClient client;
        public Kitchen()
        {
            InitializeComponent();
        }

        // nút điều khiển dây phơi quần áo nhưng tạm để tên là FAN
        private void FAN_Click(object sender, EventArgs e)
        {
            if (status_line == true)
            {
                FAN.Text = "PULL OUT";
                FAN.BackColor = Color.Blue;
                status_line = false;
                serialPort1.Write("c");
            }
            else
            {
                FAN.Text = "PULL IN";
                FAN.BackColor = Color.Red;
                status_line = true;
                serialPort1.Write("d");
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

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //rcv_data = serialPort1.ReadLine();
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.PortName = "COM4";
            serialPort1.Open();
            client = new FireSharp.FirebaseClient(config);
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Warning");

            String warm  = response.ResultAs<String>();
            
            String transt = warm.ToString();

            if (transt == "f")
            WARNING.Text = "THERE IS FIRE";

            if (transt == "g")
                WARNING.Text = "GAS LEAKAGE";


            if (transt == "t")
             WARNING.Text = "HIGH TEMPERATURE";


            if (transt == "pir")
                WARNING.Text = "SUSPICIOUS OBJECT";

            if (transt == "r")
                WARNING.Text = "IT'S RAINING";

            if (transt == "n")
                WARNING.Text = "NORMAL";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WARNING_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {

        }
    }
}
