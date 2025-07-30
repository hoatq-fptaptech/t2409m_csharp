using System;
namespace T2409M_CSharp.session2
{
	public class Car
	{
		public string Brand { get; set; }
		public List<string> Maintains { get; set; }

		// indexer
		public string this [int index] {
			get { return Maintains[index]; }
			set { Maintains[index] = value; }

		}
		
    }
}

