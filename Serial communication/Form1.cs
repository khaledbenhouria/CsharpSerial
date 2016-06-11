using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Initializing the I/O ports

namespace Serial_communication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_ports.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_baudrate.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox_ports_Click(object sender, EventArgs e)
        {
            // serial ports checking
            string[] ports = SerialPort.GetPortNames();
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(ports);
        }

        private void button_con_Click(object sender, EventArgs e)
        {
            if (!serialPort_main.IsOpen) { //checks if serial ports is connected
                if (comboBox_ports.Text != "" && comboBox_baudrate.Text != "")
                { //configuring the serial
                    serialPort_main.PortName = comboBox_ports.Text;
                    serialPort_main.BaudRate = Convert.ToInt32(comboBox_baudrate.Text);
                    try { serialPort_main.Open(); }
                    catch (Exception){
                        MessageBox.Show("Port Seems Busy");
                    }
                }
                else {
                    MessageBox.Show("Please check your information");
                }
            }else
            {// if serial Port is  connected
                serialPort_main.Close();
            }
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            if (serialPort_main.IsOpen)
            { //checks if serial ports is connected
                label_status.Text = "Connected";
                button_con.Text = "Disconnect";
                button_send.Enabled = true;
                if (serialPort_main.BytesToRead > 0) {
                    string indata = serialPort_main.ReadLine();
                    richTextBox1.Text = indata;
                    v1.Text = (fetchvalue(indata, "v1") == "false") ? v1.Text : fetchvalue(indata, "v1");
                    v2.Text = (fetchvalue(indata, "v2") == "false") ? v2.Text : fetchvalue(indata, "v2");
                    v3.Text = (fetchvalue(indata, "v3") == "false") ? v3.Text : fetchvalue(indata, "v3");
                }
            }
            else
            {// if serial Port is  connected
                label_status.Text = "Not Connected";
                button_con.Text = "Connect";
                button_send.Enabled = false;
            }
            
        }

        string fetchvalue(string temp, string expected)
        {
            string[] values = temp.Split(';');
            expected += ":";
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Contains(expected))
                {
                    if (!values[i].Substring(expected.Length).Contains(':'))
                        return values[i].Substring(expected.Length);
                }
            }
            return "false";
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            serialPort_main.Write(richTextBox_send.Text);
        }
    }
}
