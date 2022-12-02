using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace ProjetResto.Modèle.Cuisine
{
	class Client
	{
		static Socket sck;
		static void Main(string[] args)
		{
			sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
			try
			{
				sck.Connect(localEndPoint);
			}
			catch
			{
				Console.Write("Impossible de connecter! \r\n");
				Main(args);
			}
			Console.Write("Envoyez à la cuisine : ");
			string text = Console.ReadLine();
			byte[] data = Encoding.ASCII.GetBytes(text);

			sck.Send(data);
			Console.Write("Bien recu de la part de la Cuisine...");
			Console.Read();
			sck.Close();
		}
	}
}
