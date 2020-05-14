using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Chatapp_Egen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serverConnect_Click(object sender, EventArgs e)
        {
            
        }

        private void clientConnect_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(messageTextBox.Text);
            IPAddress serverIP = IPAddress.Parse("192.168.1.6");
            IPEndPoint destination = new IPEndPoint(serverIP, 12345);
            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);
        }

        private void receive_Click(object sender, EventArgs e)
        {
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(12345);
            byte[] inström = client.Receive(ref klientEndPoint);
            messageTextBox.Text = Encoding.Unicode.GetString(inström);
        }
    }
}
