using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDP_Chatapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(messageBox.Text);
            IPAddress serverIP = IPAddress.Parse(serverBox.Text);
            IPEndPoint destination = new IPEndPoint(serverBox.Text, portBox.Text);
        }
    }
}
