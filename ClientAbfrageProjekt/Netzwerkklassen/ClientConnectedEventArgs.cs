using System;
using System.Net.Sockets;

namespace ClientAbfrageProjekt
{
    public class ClientConnectedEventArgs : EventArgs
    {
        public TcpClient Client { get; set; }

        public ClientConnectedEventArgs(TcpClient client)
        {
            this.Client = client;
        }
    }
}
