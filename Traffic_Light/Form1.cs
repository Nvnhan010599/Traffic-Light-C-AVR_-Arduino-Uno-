using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light
{
    public partial class Form1 : Form
    {
        int TXA = 30, TVA = 3, TXB = 40, TVB = 3;
        int T1, T2, T ,TDA, TDB;
        int t = 0,light = 0,index = 0;
        string[] data_out = new string[4];
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            status_lbl.Visible = false;
            string[] port = SerialPort.GetPortNames();
            stopbit_list.Items.Add(StopBits.One);
            stopbit_list.Items.Add(StopBits.OnePointFive);
            stopbit_list.Items.Add(StopBits.Two);
            try
            {
                foreach (string nameport in port)
                {
                    com_list.Items.Add(nameport);
                }

            }
            catch
            {

            }
        }
        private void Config_serialPort()
        {

            serialPort1.PortName = com_list.Text;
            serialPort1.BaudRate = int.Parse(baudrate_list.Text);
            serialPort1.DataBits = int.Parse(datasize_list.Text);
            switch (stopbit_list.SelectedIndex)
            {
                case 0:
                    {
                        serialPort1.StopBits = StopBits.One;
                        break;
                    }
                case 1:
                    {
                        serialPort1.StopBits = StopBits.OnePointFive;
                        break;
                    }
                case 2:
                    {
                        serialPort1.StopBits = StopBits.Two;
                        break;
                    }
            }
            switch (parity_list.SelectedIndex)
            {
                case 0:
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                        break;
                    }
                case 1:
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    }
                case 2:
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Write(data_out[index]);
            index++;
            if(index == 4)
            {
                timer1.Stop();
                index = 0;
            }


        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) // closing
            {
                try
                {
                    
                    Config_serialPort();
                    serialPort1.Open();
                    status_lbl.Visible = true;
                    status_lbl.ForeColor = Color.Green;
                    status_lbl.Text = "Connected";
                    connect_btn.Text = "Disconnect";
                   // timer1.Start();

                }
                catch
                {
                    MessageBox.Show("Invalid or Empty area");
                }
            }
            else
            {
                timer1.Stop();
                serialPort1.Close();
                status_lbl.Visible = true;
                status_lbl.ForeColor = Color.Red;
                status_lbl.Text = "Disconnected";
                connect_btn.Text = "Connect";

            }
        }
        Action<string> serialPortReceiverAction;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialPortReceiverAction = SerialPortReceiver;
            try
            {
                this.BeginInvoke(serialPortReceiverAction, serialPort1.ReadLine());
            }
            catch
            {

            }
        }
        private void SerialPortReceiver(string input)
        {
            
            string[] data = input.Split(',');
            if (data[0] == "@")
            {
                light = int.Parse(data[1]);
                label6.Text = data[2];
                label7.Text = data[3];
                if (light < 3)
                {
                    XB.BackColor = Color.White;
                    VB.BackColor = Color.White; 
                    DB.BackColor = Color.Red;
                    DA.BackColor = Color.White;
                    label7.ForeColor = Color.Red;
                    if (light == 2)
                    {
                        VA.BackColor = Color.Yellow;
                        XA.BackColor = Color.White;
                        label6.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        XA.BackColor = Color.GreenYellow;
                        VA.BackColor = Color.White;
                        label6.ForeColor = Color.GreenYellow;
                    }
                }
                else
                {
                    label6.ForeColor = Color.Red;
                    XA.BackColor = Color.White;
                    VA.BackColor = Color.White;
                    DA.BackColor = Color.Red;
                    DB.BackColor = Color.White;
                    if (light == 4)
                    {
                        label7.ForeColor = Color.Yellow;
                        VB.BackColor = Color.Yellow;
                        XB.BackColor = Color.White;
                    }
                    else
                    {
                        label7.ForeColor = Color.GreenYellow;
                        XB.BackColor = Color.GreenYellow;
                        VB.BackColor = Color.White;
                    }
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                timer1.Start();
                data_out[0] = CheckValue("XA",t_XA.Text);
                data_out[1] = CheckValue("VA", t_VA.Text);
                data_out[2] = CheckValue("XB", t_XB.Text);
                data_out[3] = CheckValue("VB", t_VB.Text);
            }
            
        }
        private string CheckValue(string para,string value)
        {
            if(int.Parse(value)> 9)
            {
                return para + "0000" + value;
            }
            return  para + "00000" + value;
        }
    }
}
