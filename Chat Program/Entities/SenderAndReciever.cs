using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Program.Entities
{
	public class SenderAndReciever
	{
		public static void Send()
		{
			var soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			var ip = IPAddress.Parse("");//IPADDRESS
			var port = 27001;
			var ep = new IPEndPoint(ip, port);
		}
	}
}
