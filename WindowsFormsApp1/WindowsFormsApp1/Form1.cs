using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int posx = 32;
        private int posy = 32;
        private bool posChanged = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //TODO
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            posx = e.X;
            posy = e.Y;
            posChanged=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if(posChanged)
                {
                    sendData(true, (byte)(posx * 64 / ClientSize.Width));
                    sendData(false, (byte)(posy * 64 / ClientSize.Height));
                    posChanged = false;
                }
            }
            catch(DivideByZeroException)
            {
                
            }
        }
        private void sendData(bool dir, int pos)
        {
            if(dir)
            {
                //Send Data for right motor
                byte[] b = new byte[1];
                b[0] = 0x80;                // 1000 0000
                b[0] |= (byte)(0x3F & pos);
                labelOutR.Text = "R: " + pos;
                //port.Write(b, 0, 1);
            }
            else
            {
                //Send Data for left motor
                byte[] b = new byte[1];
                b[0] = 0x40;                // 0100 0000
                b[0] |= (byte)(0x3F & pos);
                labelOutL.Text = "L: " + pos;
                //port.Write(b, 0, 1);
            }
        }
    }
}
