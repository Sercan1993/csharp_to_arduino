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

namespace csharp_to_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM6";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }
    }
}
