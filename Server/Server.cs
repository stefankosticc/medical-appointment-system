using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class Server
    {
        private Socket socket;
        private List<ClientHandler> handlers;
        private FrmServer serverForm;

        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            handlers = new List<ClientHandler>();
            serverForm = new FrmServer();
        }

        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

            socket.Bind(endPoint);
            socket.Listen();

            Thread nitServera = new Thread(AcceptClient);
            nitServera.Start();
        }

        private void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    Debug.WriteLine("Klijent je povezan");

                    ClientHandler handler = new ClientHandler(klijentskiSoket, this);
                    handlers.Add(handler);

                    Thread obradaZahteva = new Thread(handler.HandleRequest);
                    obradaZahteva.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void Stop()
        {
            List<ClientHandler> handlersCopy = new List<ClientHandler>(handlers);
            foreach (ClientHandler handler in handlersCopy)
            {
                handler.CloseSocket();
            }
            handlers.Clear();
            socket.Close();
        }

        private object _lock = new object();

        internal void RemoveClient(ClientHandler clientHandler)
        {
            lock (_lock)
            {
                handlers.Remove(clientHandler);
            }
        }
    }
}
