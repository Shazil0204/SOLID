using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine.Model
{
	public class BasicCoffeeMachine : CoffeeMachine
	{
		public override void MakeCoffee(int cups)
		{
			int requiredWater = cups * 200;
			int requiredBeans = cups * 10;

			if (Filter.FilterInserted && WaterContainer.WaterLevel >= requiredWater && CoffeeBeansContainer.CoffeeBeans >= requiredBeans)
			{
				WaterContainer.UseWater(requiredWater);
				CoffeeBeansContainer.UseCoffeeBeans(requiredBeans);
				CupsToMake = cups;
				Console.WriteLine($"{cups} cups of coffee made.");
			}
			else
			{
				Console.WriteLine("Not enough water, coffee beans, or no filter inserted.");
			}
		}

		public override void CleanMachine()
		{
			Console.WriteLine("Cleaning the machine...");
			WaterContainer = new WaterContainer();
			Filter = new Filter();
			CoffeeBeansContainer = new CoffeeBeansContainer();
			CupsToMake = 0;
			Console.WriteLine("Machine cleaned.");
		}
	}
}
