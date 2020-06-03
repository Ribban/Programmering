using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
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
        /// <summary>
        /// Funktion för att ta emot meddelanden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receive_Click(object sender, EventArgs e)
        {
            //Skapar ny instans av IPEndPoint med ipadress och portnummer
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            //Binder UdpClient till portnummret 12345
            UdpClient client = new UdpClient(12345);
            //Tar emot meddelandet
            byte[] instream = client.Receive(ref clientEndPoint);
            //Visar meddelandet i rutan
            messageTextBox.Text = Encoding.Unicode.GetString(instream);
        }
    }
}
