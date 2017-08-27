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

namespace GemCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox_Available_SerialPorts.Items.AddRange(SerialPort.GetPortNames());

            string SystemInformation;

            SystemInformation = " Machine Name = " + System.Environment.MachineName;
            SystemInformation = SystemInformation + Environment.NewLine + " OS Version = " + System.Environment.OSVersion;
            SystemInformation = SystemInformation + Environment.NewLine + " Processor Cores = " + System.Environment.ProcessorCount;

            RichTextBox_Log.Text = SystemInformation;

            GroupBox_SeriaL_Receive.Enabled = false;
            GroupBox_Serial_Transmit.Enabled = false;
            ComboBox_Standard_Baudrates.Enabled = false;
            GroupBox_Commands.Enabled = false;

            Label_COM_Status.Text = "Closed";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboBox_Available_SerialPorts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RichTextBox_Log.Text = ComboBox_Available_SerialPorts.SelectedItem.ToString() + " Selected";
            ComboBox_Standard_Baudrates.Enabled = true;
        }

        private void ComboBox_Standard_Baudrates_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RichTextBox_Log.Text = RichTextBox_Log.Text + Environment.NewLine + ComboBox_Standard_Baudrates.SelectedItem.ToString() + " Selected";
            GroupBox_Commands.Enabled = true;
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            string Port_Name = ComboBox_Available_SerialPorts.SelectedItem.ToString();
            int Baud_Rate = Convert.ToInt32(ComboBox_Standard_Baudrates.SelectedItem);
            string Data = "Neki";

            COMport.BaudRate = Baud_Rate;
            COMport.PortName = Port_Name;

            try
            {
                COMport.Open();
            }
            catch (System.IO.IOException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                COMport.Close();
            }
            catch (UnauthorizedAccessException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                COMport.Close();
            }
            catch (InvalidOperationException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                COMport.Close();
            }
            catch
            {
                MessageBox.Show("Unknown ERROR when opening serial port" + COMport);
                COMport.Close();
            }

            if(COMport.IsOpen == true)
            {
                Label_COM_Status.Text = "Open";
                RichTextBox_Log.Text = RichTextBox_Log.Text + Environment.NewLine + Port_Name + " opened at " + ComboBox_Standard_Baudrates.SelectedItem.ToString() + " baudrate";
                GroupBox_SeriaL_Receive.Enabled = true;
                GroupBox_Serial_Transmit.Enabled = true;
            }
            else
            {
                COMport.Close();
                RichTextBox_Log.Text = RichTextBox_Log.Text + Environment.NewLine + Port_Name + " failed to open";
            }
        }

        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            COMport.Close();
            RichTextBox_Log.Text = RichTextBox_Log.Text + Environment.NewLine + COMport.PortName + " closed";
            GroupBox_SeriaL_Receive.Enabled = false;
            GroupBox_Serial_Transmit.Enabled = false;
        }

        private void COMport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string indata = COMport.ReadLine();
            RichTextBox_Log.Text = RichTextBox_Log.Text + Environment.NewLine + indata;
        }
    }
}
