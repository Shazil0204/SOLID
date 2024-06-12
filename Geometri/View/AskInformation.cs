using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.View
{
	public class AskInformation
	{
		public int Value()
		{
			return Convert.ToInt32(Console.ReadLine());
		}
		public  sbyte SelectOption()
		{
			return Convert.ToSByte(Console.ReadLine());
		}
	}
}
