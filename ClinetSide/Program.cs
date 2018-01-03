using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ClinetSide
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = 
            new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            socket.Connect(IPAddress.Parse("127.0.0.1"),10483);

            NetworkStream stream = new NetworkStream(socket);

            BinaryWriter writer= new BinaryWriter(stream);
            while(true){
            writer.Write("Hello World");
            System.Console.WriteLine((new BinaryReader(stream)).ReadString());
            Thread.Sleep(500);
}
        }
    }
}
