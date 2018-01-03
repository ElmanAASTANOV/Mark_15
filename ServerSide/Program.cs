using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerSide
{
    class Program
    {

        public void r()
        {
         TcpListener listenerSocket = new TcpListener(IPAddress.Parse("127.0.0.1"),10483);
            listenerSocket.Start();
            Socket istemcisocket = listenerSocket.AcceptSocket();
            IPEndPoint d = istemcisocket.RemoteEndPoint as IPEndPoint;
            IPEndPoint y = istemcisocket.LocalEndPoint as IPEndPoint;

            Console.WriteLine("Remote :" + d.Address + ":"+d.Port);
            Console.WriteLine("Local :" + y.Address + ":" +d.Port);
            NetworkStream stream = new NetworkStream(istemcisocket);

            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);

while(true){
            string msg = reader.ReadString();

            Console.WriteLine(msg); 
            writer.Write("eleykim salam World");
            Thread.Sleep(500);
}
        
        }

        static  void Main(string[] args)
        {
           Program t = new Program();
           t.r();

        }
    }
}
