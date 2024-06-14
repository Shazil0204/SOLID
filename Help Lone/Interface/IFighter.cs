using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Lone.Interface
{
	internal interface IFighter
	{
		int Strength { get; set; }
		void Bash();
		void Cleave();
		void Slash();
	}
}
