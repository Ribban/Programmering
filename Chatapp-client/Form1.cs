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
        /// <summary>
        /// Skickar ett meddelande över nätverket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void send_Click(object sender, EventArgs e)
        {
            //Tar emot meddelandet som ska skickas
            byte[] message = Encoding.Unicode.GetBytes(messageTextBox.Text);
            //Converterar en sträng till ipadress
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            //Skapar en ny instans av IPEndPoint med ipadress och portnummer
            IPEndPoint destination = new IPEndPoint(serverIP, 12345);
            //Initierar en ny instans av UdpClient
            UdpClient client = new UdpClient();
            //Tar meddelandet och skickar det över nätverket
            client.Send(message, message.Length, destination);
        }
    }
}
