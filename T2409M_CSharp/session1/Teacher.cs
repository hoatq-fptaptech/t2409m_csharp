using System;
namespace T2409M_CSharp.session1
{
	public class Teacher
	{
		private string name;
		private string email;

		// properties
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Email
		{
			get => name;
			set => name = value;
		}

		// abtract properties
		public string Address { get; set; }

		public void Teaching()
		{

		}
		
	}
}

