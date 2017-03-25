using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoUI
{
    public partial class Form1 : Form
    {

        private SerialPort serial;
  
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Calistir();
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            Durdur();
        }

        private void Setup()
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void Calistir()
        {
            serial.Write("1");
            Debug.WriteLine("Gönderildi");
        }

        private void Durdur()
        {
            serial.Write("0");
            Debug.WriteLine("Durduruldu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serial = new SerialPort(comboBox1.Text, 9600);
            serial.Open();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serial != null && serial.IsOpen)
            {
                serial.Close();
            }
        }
    }
}
