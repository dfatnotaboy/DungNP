using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyModbus;


namespace Palletizer
{
    public partial class Connect : Form
    {
        ModbusClient modBus = new ModbusClient();

        public Connect()
        {
            InitializeComponent();

        }

        private void ModbusTCP()
        {
            int b = 0;
            do
            {
                modBus.IPAddress = Convert.ToString(tbIP.Text);
                modBus.Port = Convert.ToInt32(tbPort.Text);
                try
                {
                    modBus.Connect();
                }
                catch (Exception)
                {
                b++;    
                }
                if (modBus.Connected == true)
                {
                    lbStatus.Text = "Connected !!";
                   
                }
            }
            while (b < 5);
            {
                MessageBox.Show("Check IP or Port and connect agian !! ");
                
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
         
            ModbusTCP();
            
        }

        private void btD200_Click(object sender, EventArgs e)
        {
            modBus.WriteSingleRegister(0,Convert.ToInt32(tbD200.Text));
        }
    }
}
