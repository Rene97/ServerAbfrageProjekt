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

namespace ClientAbfrageProjekt
{
    public partial class Client1 : Form
    {

        AsyncTcpClient Client;

        public Client1()
        {
            InitializeComponent();
        }

        private void Client1_Load(object sender, EventArgs e)
        {
            Client = new AsyncTcpClient();
            Client.Connected += Client_Connected;
            Client.PacketReceived += Client_PacketReceived;
            
        }

        void Client_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void Client_Connected(object sender, ClientConnectedEventArgs e)
        {
            MessageBox.Show("Client Connected");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Client.IsConnected)
            {
                Client.Connect(IPAddress.Parse("127.0.0.1"), 7);
            }
            else
            {
                MessageBox.Show("Bereits Verbunden");
            }
            
        }
        
    }
}
