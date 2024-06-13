using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine.Model.Interface
{
	internal interface ICoffee
	{
		
		void MakeCoffee(int cups);
		void CleanMachine();

	}
}
