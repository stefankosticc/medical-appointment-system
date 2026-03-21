using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    internal class Communication
    {
        private static Communication instance;

        private Communication() { }

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        private Socket socket;
        private JsonNetworkSerializer serializer;

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            serializer = new JsonNetworkSerializer(socket);
        }

        internal Response PrijaviZaposleni(Zaposleni zaposleni)
        {
            Request request = new Request
            {
                Argument = zaposleni,
                Operation = Operation.PrijaviZaposleni
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<Zaposleni>(response.Data);

            return response;
        }
    }
}
