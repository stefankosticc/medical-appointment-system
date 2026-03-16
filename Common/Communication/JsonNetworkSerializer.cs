using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Common.Communication
{
    public class JsonNetworkSerializer
    {
        private readonly Socket _socket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public JsonNetworkSerializer(Socket socket)
        {
            this._socket = socket;                                                                                          
            stream = new NetworkStream(socket);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
        }

        public void Send(object data)
        {
            writer.WriteLine(JsonSerializer.Serialize(data));
        }

        public T Receive<T>()
        {
            string json = reader.ReadLine();
            return JsonSerializer.Deserialize<T>(json);
        }

        public T? ReadType<T>(object data) where T : class
        {
            return data == null ? null : JsonSerializer.Deserialize<T>((JsonElement)data);
        }

        public void Close()
        {
            stream.Close();
            reader.Close();
            writer.Close();
        }
    }
}
