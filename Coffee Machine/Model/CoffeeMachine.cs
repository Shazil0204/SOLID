using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Machine.Model.Interface;

namespace Coffee_Machine.Model
{
	public abstract class CoffeeMachine: ICoffee
	{
		public WaterContainer WaterContainer;
		public Filter Filter;
		public CoffeeBeansContainer CoffeeBeansContainer;
		public int CupsToMake { get; protected set; }

		public CoffeeMachine()
		{
			WaterContainer = new WaterContainer();
			Filter = new Filter();
			CoffeeBeansContainer = new CoffeeBeansContainer();
			CupsToMake = 0;
		}

		public abstract void MakeCoffee(int cups);
		public abstract void CleanMachine();
	}
}
