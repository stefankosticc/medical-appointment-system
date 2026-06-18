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

        public Response VratiListuSviZaposleni(Zaposleni zaposleni)
        {
            Request request = new Request
            {
                Operation = Operation.VratiListuSviZaposleni,
                Argument = zaposleni
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<List<Zaposleni>>(response.Data);
            return response;
        }

        public Response VratiListuSviKategorijaPacijenta(KategorijaPacijenta kategorija)
        {
            Request request = new Request
            {
                Operation = Operation.VratiListuSviKategorijaPacijenta,
                Argument = kategorija
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<List<KategorijaPacijenta>>(response.Data);
            return response;
        }

        public Response KreirajPacijent(Pacijent pacijent)
        {
            Request request = new Request
            {
                Operation = Operation.KreirajPacijent,
                Argument = pacijent
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<Pacijent>(response.Data);
            return response;
        }

        public Response PromeniPacijent(Pacijent pacijent)
        {
            Request request = new Request
            {
                Operation = Operation.PromeniPacijent,
                Argument = pacijent
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<Pacijent>(response.Data);
            return response;
        }

        public Response VratiListuSviPacijent(Pacijent pacijent)
        {
            Request request = new Request
            {
                Operation = Operation.VratiListuSviPacijent,
                Argument = pacijent
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<List<Pacijent>>(response.Data);
            return response;
        }

        public Response PretraziPacijent(Pacijent kriterijum)
        {
            Request request = new Request
            {
                Operation = Operation.PretraziPacijent,
                Argument = kriterijum
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<List<Pacijent>>(response.Data);
            return response;
        }

        public Response VratiListuPacijent(Pacijent kriterijum)
        {
            Request request = new Request
            {
                Operation = Operation.VratiListuPacijent,
                Argument = kriterijum
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<List<Pacijent>>(response.Data);
            return response;
        }

        public Response ObrisiPacijent(Pacijent pacijent)
        {
            Request request = new Request
            {
                Operation = Operation.ObrisiPacijent,
                Argument = pacijent
            };
            serializer.Send(request);
            return serializer.Receive<Response>();
        }

        public Response VratiListuSviUsluga(Usluga usluga)
        {
            Request request = new Request
            {
                Operation = Operation.VratiListuSviUsluga,
                Argument = usluga
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<List<Usluga>>(response.Data);
            return response;
        }

        public Response UbaciUsluga(Usluga usluga)
        {
            Request request = new Request
            {
                Operation = Operation.UbaciUsluga,
                Argument = usluga
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<Usluga>(response.Data);
            return response;
        }

        public Response PromeniUsluga(Usluga usluga)
        {
            Request request = new Request
            {
                Operation = Operation.PromeniUsluga,
                Argument = usluga
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            response.Data = serializer.ReadType<Usluga>(response.Data);
            return response;
        }
    }
}
