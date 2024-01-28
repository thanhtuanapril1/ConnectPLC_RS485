using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using EasyModbus.Exceptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        ModbusClient ModClient;
        int timer_count = 0;
        int transfer_count = 0;
        int btReadHoldingAuto_Count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Initial Modbus properties
            ModClient = new ModbusClient(cBoxPort.Text);
			ModClient.UnitIdentifier = 1;
			ModClient.ConnectionTimeout = 20;

            ModClient.Baudrate = int.Parse(cBoxBaudrate.Text);

            if (cBoxParity.Text == "None") ModClient.Parity = System.IO.Ports.Parity.None;
            else if (cBoxParity.Text == "Even") ModClient.Parity = System.IO.Ports.Parity.Even;
            else if (cBoxParity.Text == "Odd") ModClient.Parity = System.IO.Ports.Parity.Odd;


            //Connect Mosbus
            try
            {
                ModClient.Connect();
                if (ModClient.Connected == true) lblStatus.Text = "Connected";
                btConnect.Enabled = false;
                btDisconnect.Enabled = true;
                grpRW.Enabled = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error! " + ex.ToString();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ModClient.Disconnect();
            if (ModClient.Connected == false)
            {
                lblStatus.Text = "Disconnected";
                btConnect.Enabled = true;
                btDisconnect.Enabled = false;
                grpRW.Enabled = false;
                timer1.Enabled = false;
                timer_count = 0;
                transfer_count = 0;
                btReadHoldingAuto_Count = 0;
                lblTimerCount.Text = "0";
                lblTransCount.Text = "0";
            }
            else lblStatus.Text = "Disconnect Failed";

        }

        private void btnReadHolding_Click(object sender, EventArgs e)
        {
            ModClient.UnitIdentifier = 1;
            try
            {
                int[] vals;
                vals = ModClient.ReadHoldingRegisters(int.Parse(txtReg.Text), 1);
                txtValue.Text = vals[0].ToString();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error! " + ex.ToString();
            }

        }

        private void btnWriteHolding_Click(object sender, EventArgs e)
        {
            ModClient.UnitIdentifier = 2;
            txtValue.Text = "50";
            int count = 0;
            while (true)
            {
                try
                {
                    for (int i = 0; i < 20; i++)
                    {
                        txtValue.Text = i.ToString();
                        ModClient.WriteSingleRegister(int.Parse(txtReg.Text), int.Parse(txtValue.Text));
                    }
                    lblStatus.Text = "Done loop";
                    break;
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error! " + ex.ToString();
                    if (++count == 3) throw ex;

                }
            }

        }

        private void btReadHoldingAuto_Click(object sender, EventArgs e)
        {
            btReadHoldingAuto_Count++;
            if (btReadHoldingAuto_Count % 2 == 0) timer1.Enabled = false;
            else timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            try
            {
                timer_count++;
                lblTimerCount.Text = timer_count.ToString();
                int[] vals;
                for (byte j = 1; j < 4; j++)
                {
                    ModClient.UnitIdentifier = j;
                    vals = ModClient.ReadHoldingRegisters(int.Parse(txtReg.Text), 1);

                    if (j == 1) txtValue_1.Text = vals[0].ToString();
                    if (j == 2) txtValue_2.Text = vals[0].ToString();
                    if (j == 3) txtValue_3.Text = vals[0].ToString();
                }
                transfer_count++;
                lblTransCount.Text = transfer_count.ToString();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error! " + ex.ToString();
            }

        }

        private void btnReadAnalog_Click(object sender, EventArgs e)
        {
            int[] vals;
            vals = ModClient.ReadInputRegisters(int.Parse(txtReg.Text), 1);
            txtValue.Text = vals[0].ToString();
        }

        private void btnReadCoil_Click(object sender, EventArgs e)
        {
            bool[] vals;
            vals = ModClient.ReadCoils(int.Parse(txtReg.Text), 1);
            txtValue.Text = vals[0].ToString();
        }

        private void btnWriteCoil_Click(object sender, EventArgs e)
        {
            ModClient.WriteSingleCoil(int.Parse(txtReg.Text), bool.Parse(txtValue.Text));
        }

        private void btnReadDigital_Click(object sender, EventArgs e)
        {
            bool[] vals;
            vals = ModClient.ReadDiscreteInputs(int.Parse(txtReg.Text), 1);
            txtValue.Text = vals[0].ToString();
        }




    }
}
