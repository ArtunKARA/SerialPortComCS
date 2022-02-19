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
        string dataIn;
        //string result = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            serialPort1.DtrEnable = false;
            cbRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;
            cbDrtEnable.Checked = false;
            btSendData.Enabled = false;
            cbWrite.Checked = true;
            btOpen.Enabled = true;
            btClose.Enabled = false;
            cbAlwaysUpdate.Checked = true;
            
            
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
                lbComPortStatus.Text = "ON";
                lbComPortStatus.ForeColor = Color.Green;
                btClose.Enabled = true;
                btOpen.Enabled = false;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                lbComPortStatus.Text = "OFF";
                lbComPortStatus.ForeColor = Color.Red;
                btClose.Enabled = false;
                btOpen.Enabled = true;
            }
        }

        private void btSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = textBox1.Text;
                if (cbWriteLine.Checked)
                {
                    serialPort1.WriteLine(dataOut);
                }
                else
                {
                    serialPort1.Write(dataOut);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbDrtEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDrtEnable.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DRT Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else 
            { 
                serialPort1.DtrEnable = false; 
            }
        }

        private void cbRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRtsEnable.Checked) 
            {
             serialPort1.RtsEnable = true;
             MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.RtsEnable= false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                textBox1.Text = "";
            }
        }

        private void lbDataOutLength_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength = textBox1.TextLength;
            lbDataOutLength.Text = string.Format("{0:00}", dataOutLength);
        }

        private void lbComPortStatus_Click(object sender, EventArgs e)
        {

        }

        private void cbUssingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUssingButton.Checked)
            {
                btSendData.Enabled = true;
            }
            else
            {
                btSendData.Enabled= false;
            }
        }

        private void cbWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWriteLine.Checked)
            {
                cbWrite.Checked = false;
                
                
            }
        }

        private void cbWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWrite.Checked)
            {
                cbWriteLine.Checked = false;
                
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbUssingEnter.Checked)
            {
                if (e.KeyCode==Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOut = textBox1.Text;
                        if (cbWriteLine.Checked)
                        {
                            serialPort1.WriteLine(dataOut);
                        }
                        else
                        {
                            serialPort1.Write(dataOut);
                        }
                    }
                }
            }
        }

     

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string input = serialPort1.ReadExisting(); 
            //string playground = input;
            //while (playground.Length > 0)
            //{
            //    int temp = Convert.ToInt32(playground.Substring(0, 2));
            //    if (temp < 32)
            //    {
            //        temp = Convert.ToInt32(playground.Substring(0, 3));
            //    }
            //    result += (Convert.ToChar(temp)).ToString();
            //    playground = playground.Substring(temp.ToString().Length, playground.Length - temp.ToString().Length);
            //}
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));

        }

        private void ShowData(object sender, EventArgs e)
        {
            
            if (cbAlwaysUpdate.Checked)
            {
                textBox2.Text = dataIn;
            }
            else
            {
                textBox2.Text += dataIn;
            }
        }

        private void cbAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlwaysUpdate.Checked)
            {
                cbAddToOldData.Checked = false;

            }
        }

        private void cbAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddToOldData.Checked)
            {
                cbAlwaysUpdate.Checked = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int dataInLength = textBox2.TextLength;
            lbDataInLength.Text = string.Format("{0:00}", dataInLength);
        }

        private void btClearDataIn_Click(object sender, EventArgs e)
        {
            if (textBox2.Text !="")
            {
                textBox2.Clear();
            }
        }
    }   
}