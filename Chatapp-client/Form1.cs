using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Chatapp_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(messageTextBox.Text);
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint destination = new IPEndPoint(serverIP, 12345);
            UdpClient client = new UdpClient();
            client.Send(message, message.Length, destination);
        }
    }
}
