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
using System.Reflection;

namespace BLUETOOTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Com.Write("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Com.WriteLine("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Com.Write("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Com.WriteLine("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Com.WriteLine("5");
        }
        int intlen = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                comboBox1.Items.Clear();
                for (int j = 0; j < intlen; j++)
                {
                    comboBox1.Items.Add(ports[j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Disconnect")
            {
                Com.PortName = comboBox1.Text;
                Com.Open();
                label2.Text = "Connect";
                button1.Text = "Disconnect";
            }
            else
            {
                Com.Close();
                label2.Text = "Disconnect";
                button1.Text = "Connect";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Up)
            {
                button2.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Left)
            {
                button3.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Right)
            {
                button5.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Down)
            {
                button6.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Space)
            {
                button4.PerformClick();
            }
        }
    }
}
