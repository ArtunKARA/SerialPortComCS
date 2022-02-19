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

namespace SerialPortCom
{
    public partial class Form1 : Form
    {
        string dataOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt16(cbBaundRate.Text);
                serialPort1.DataBits = Convert.ToInt16(cbDataBirts.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParityBits.Text);


                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value=0;
            }
        }

        private void btSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = textBox1.Text;
                serialPort1.WriteLine(dataOut);
            }
        }
    }
}
