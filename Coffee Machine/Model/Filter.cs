using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine.Model
{
	public class Filter
	{
		public bool FilterInserted { get; private set; }

		public void InsertFilter()
		{
			FilterInserted = true;
			Console.WriteLine("Filter inserted.");
		}

		public void RemoveFilter()
		{
			FilterInserted = false;
			Console.WriteLine("Filter removed.");
		}
	}
}
