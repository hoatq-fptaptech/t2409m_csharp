using System;
namespace T2409M_CSharp.session1
{
	public class Student
	{
		public string name;
		public int age;
		public string telephone;

		public Student() // constructor
		{
			Console.WriteLine("Student constructor...");
		}

		// properties


		public void learn()
		{
			Console.WriteLine("Student is learning...");
		}

		public void learn(string msg)
		{
			Console.WriteLine("Learning... " + msg);
		}
	}
}

