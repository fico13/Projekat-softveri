using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Main
{
    public class Server
    {
        private Socket serverSoket;
        private List<ClientHandler> clients = new List<ClientHandler>();
        private List<Administrator> administrators = new List<Administrator>();
        internal void Start()
        {
            if(serverSoket == null)
            {
                serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000));
                serverSoket.Listen(5);
            }
        }

        internal void ObradiKlijente()
        {
            try
            {
                while(true)
                {
                    Socket klijentSoket = serverSoket.Accept();
                    ClientHandler handler = new ClientHandler(klijentSoket, administrators);
                    clients.Add(handler);
                    handler.OdjavljeniKlijent += Handler_OdjavljeniKlijent;
                    Thread nit = new Thread(handler.ObradiZahteve);
                    nit.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>> " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>> " + ex.Message);
            }
        }

        private void Handler_OdjavljeniKlijent(object sender, EventArgs e)
        {
            clients.Remove((ClientHandler)sender);
        }

        internal void Close()
        {
            serverSoket?.Close();
            serverSoket = null;
            foreach (var client in clients.ToList())
            {
                client.CloseSocket();
            }
        }
    }
}
