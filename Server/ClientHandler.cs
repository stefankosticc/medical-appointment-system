using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class ClientHandler
    {
        private Socket socket;
        private JsonNetworkSerializer serializer;
        private readonly Server _server;

        public ClientHandler(Socket socket, Server server)
        {
            this._server = server;
            this.socket = socket;
            serializer = new JsonNetworkSerializer(socket);
        }

        internal void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request request = serializer.Receive<Request>();
                    Response response = ProcessRequest(request);
                    serializer.Send(response);
                }
            }
            catch (SocketException)
            {
                Debug.WriteLine("Komunikacija sa klijentom se prekinula");
            }
            catch (IOException)
            {
                Debug.WriteLine("Komunikacija sa klijentom se prekinula");
            }
            finally
            {
                if (socket.Connected)
                {
                    socket.Close();
                }
                _server.RemoveClient(this);
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();

            try
            {
                switch (request.Operation)
                {
                    case Operation.PrijaviZaposleni:
                        response.Data = Controller.Instance.PrijaviZaposleni(serializer.ReadType<Zaposleni>(request.Argument));
                        break;
                    case Operation.VratiListuSviZaposleni:
                        response.Data = Controller.Instance.VratiListuSviZaposleni(serializer.ReadType<Zaposleni>(request.Argument));
                        break;
                    case Operation.VratiListuSviKategorijaPacijenta:
                        response.Data = Controller.Instance.VratiListuSviKategorijaPacijenta(serializer.ReadType<KategorijaPacijenta>(request.Argument));
                        break;
                    case Operation.KreirajPacijent:
                        response.Data = Controller.Instance.KreirajPacijent(serializer.ReadType<Pacijent>(request.Argument));
                        break;
                    case Operation.PromeniPacijent:
                        response.Data = Controller.Instance.PromeniPacijent(serializer.ReadType<Pacijent>(request.Argument));
                        break;
                    case Operation.VratiListuSviPacijent:
                        response.Data = Controller.Instance.VratiListuSviPacijent(serializer.ReadType<Pacijent>(request.Argument));
                        break;
                    case Operation.PretraziPacijent:
                        response.Data = Controller.Instance.PretraziPacijent(serializer.ReadType<Pacijent>(request.Argument));
                        break;
                    case Operation.VratiListuPacijent:
                        response.Data = Controller.Instance.VratiListuPacijent(serializer.ReadType<Pacijent>(request.Argument));
                        break;
                    case Operation.ObrisiPacijent:
                        Controller.Instance.ObrisiPacijent(serializer.ReadType<Pacijent>(request.Argument));
                        break;
                    case Operation.VratiListuSviUsluga:
                        response.Data = Controller.Instance.VratiListuSviUsluga(serializer.ReadType<Usluga>(request.Argument));
                        break;
                    case Operation.UbaciUsluga:
                        response.Data = Controller.Instance.UbaciUsluga(serializer.ReadType<Usluga>(request.Argument));
                        break;
                    case Operation.PromeniUsluga:
                        response.Data = Controller.Instance.PromeniUsluga(serializer.ReadType<Usluga>(request.Argument));
                        break;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                response.ExceptionMessage = e.Message;
            }

            return response;
        }

        internal void CloseSocket()
        {
            socket.Close();
        }
    }
}
