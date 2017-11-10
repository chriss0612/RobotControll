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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool up = false;
        public bool down = false;
        public bool left = false;
        public bool right = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            label1.Text = "ADC: Test " + Convert.ToInt16(((SerialPort) sender).ReadExisting().ToCharArray()[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                port.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void Drive(bool LRPress, bool LR, bool FBPress, bool FB)
        {
            if(LRPress)
            {
                if(FBPress)
                {
                    if(FB)
                    {
                        if(LR)
                        {
                            SendData(true, 32 - speedBar.Value / 3);       //Forward Left
                            SendData(false, 32 + speedBar.Value);
                        }
                        else
                        {
                            SendData(true, 32 - speedBar.Value);       //Forward Right
                            SendData(false, 32 + speedBar.Value / 3);
                        }
                    }
                    else
                    {
                        if (LR)
                        {
                            SendData(true, 32 + speedBar.Value / 3);       //Backward Left
                            SendData(false, 32 - speedBar.Value);
                        }
                        else
                        {
                            SendData(true, 32 + speedBar.Value);       //Backward Right
                            SendData(false, 32 - speedBar.Value / 3);
                        }
                    }
                }
                else
                {
                    if(LR)
                    {
                        SendData(true, 32 + speedBar.Value);           //Turn Left
                        SendData(false, 32 + speedBar.Value);
                    }
                    else
                    {
                        SendData(true, 32 - speedBar.Value);           //Turn Right
                        SendData(false, 32 - speedBar.Value);
                    }
                }
            }
            else
            {
                if(FBPress)
                {
                    if(FB)
                    {
                        SendData(true, 32 - speedBar.Value);       //Forward Straight
                        SendData(false, 32 + speedBar.Value);
                    }
                    else
                    {
                        SendData(true, 32 + speedBar.Value);       //Backward Straight
                        SendData(false, 32 - speedBar.Value);
                    }
                }
                else
                {
                    SendData(true, 32);         //Stop
                    SendData(false, 32);
                }
            }
        }
        private void SendData(bool dir, int pos)
        {
            if(dir)
            {
                //Send Data for right motor
                byte[] b = new byte[1];
                b[0] = 0x80;                // 1000 0000
                b[0] |= (byte)(0x3F & pos);
                port.Write(b, 0, 1);
            }
            else
            {
                //Send Data for left motor
                byte[] b = new byte[1];
                b[0] = 0x40;                // 0100 0000
                b[0] |= (byte)(0x3F & pos);
                port.Write(b, 0, 1);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                down = false;
                up = true;
            }
            else if(e.KeyCode == Keys.S)
            {
                up = false;
                down = true;
            }
            else if(e.KeyCode == Keys.A)
            {
                right = false;
                left = true;
            }
            else if(e.KeyCode == Keys.D)
            {
                left = false;
                right = true;
            }
            Drive(left || right, left, up || down, up);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            else if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            Drive(left || right, left, up || down, up);
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            Drive(left || right, left, up || down, up);
        }

        private void cBBL_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBlinker();
        }
        private void cBHUPE_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBlinker();
        }

        private void cBBR_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBlinker();
        }

        private void UpdateBlinker()
        {
            byte[] b = new byte[1];
            b[0] = 0xC0;                // 1100 0000
            if (cBBR.Checked) b[0] |= 0x01;
            if (cBBL.Checked) b[0] |= 0x02;
            if (cBHUPE.Checked) b[0] |= 0x04;
            port.Write(b, 0, 1);
        }

    }
}
