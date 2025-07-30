using System;
namespace T2409M_CSharp.session3
{
	public delegate void SendNotify (string a, string b);
	public class Box
	{
		public static void BoxOpen(string b)
		{
			Console.WriteLine("Box open:"+b);
		}

		public static void SMS(string telephone,string msg)
		{

		}

		public static void Email(string email, string msg)
		{

		}
		public static void Zalo(string telephone, string msg)
		{

		}
		public static void Telegram(string teleID, string msg)
		{

		}
	}
}

