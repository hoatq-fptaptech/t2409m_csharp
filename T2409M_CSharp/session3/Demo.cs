using System;
namespace T2409M_CSharp.session3
{
	public delegate void ShowString(string s);
	public class Demo
	{
		public static void PrintMsg(string msg)
		{
			Console.WriteLine("Print:"+msg);
		}

		public void Alert(string notify) {
			Console.WriteLine("Alert:"+notify);
		}
	}
}

