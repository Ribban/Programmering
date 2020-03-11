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
using System.IO;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string textToSend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress adress in localIP)
            {
                if (adress.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverBox.Text = adress.ToString();
                }
            }
        }

        private void serverConnect_Click(object sender, EventArgs e)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(serverBox.Text));
                listener.Start();
                this.Update();
                infoBox.AppendText("Server started" + "\n");
                infoBox.Update();
                client = listener.AcceptTcpClient();
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void clientConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                IPEndPoint ipEND = new IPEndPoint(IPAddress.Parse(clientBox.Text), int.Parse(clientBox.Text));
            }
            catch
            {

            }
        }
    }
}
