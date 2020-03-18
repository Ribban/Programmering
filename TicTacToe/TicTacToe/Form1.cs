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
                client.Connect(ipEND);
                if (client.Connected)
                {
                    this.Update();
                    infoBox.AppendText("Connected to server" + "\n");
                    infoBox.Update();
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        enum PlayerTurn { None, Player1, Player2 };
        enum Winner { None, Player1, Player2, Draw };

        PlayerTurn turn;
        Winner winner;

        void OnNewGame()
        {
            PictureBox[] allPictures = { a1, a2, a3, b1, b2, b3, c1, c2, c3 };
            foreach (var p in allPictures)
            {
                p.Image = null;
            }
            turn = PlayerTurn.Player1;
            winner = Winner.None;
            ShowTurn();
        }
        Winner GetWinner()
        {
            PictureBox[] winningMoves = {
                                             a1, a2, a3,
                                             b1, b2, b3,
                                             c1, c2, c3,
                                             a1, b1, c1,
                                             a2, b2, c2,
                                             a3, b3, c3,
                                             a1, b2, c3,
                                             a3, b2, c1
                                          };
            for (int i = 0; i < winningMoves.Length; i += 3)
            {

            }

        }
        void ShowTurn()
        {

        }
        private void OnClick(object sender, EventArgs e)
        {

        }
    }
}
