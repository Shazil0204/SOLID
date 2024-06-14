using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine.Model.Interface
{
	/// <summary>
	/// This is my basic Interface with 2 default tasks
	/// </summary>
	internal interface ICoffee
	{
		void MakeCoffee(int cups);
		void CleanMachine();
	}
}
