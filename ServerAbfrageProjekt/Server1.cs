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

namespace ServerAbfrageProjekt
{
    public partial class Server1 : Form
    {
        AsyncTcpServer server; 

        public Server1()
        {
            InitializeComponent();
        }

        private void Server1_Load(object sender, EventArgs e)
        {
            server = new AsyncTcpServer(IPAddress.Parse("127.0.0.1"), 7);
            server.ClientConnected += server_ClientConnected;
            server.PacketReceived += server_PacketReceived;
            server.Start();
        }

        void server_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void server_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            MessageBox.Show("Client Verbunden");
        }
    }
}
