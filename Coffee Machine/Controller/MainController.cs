using Coffee_Machine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine.Controller
{
	internal class MainController
	{
		/// <summary>
		/// This method will call the whole program
		/// </summary>
		public void Terminal()
		{
			CoffeeMachine myCoffeeMachine = new BasicCoffeeMachine();
			// Simulating the process of making coffee
			myCoffeeMachine.CleanMachine();
			myCoffeeMachine.WaterContainer.AddWater(1000); // Adding 1000ml of water
			myCoffeeMachine.Filter.InsertFilter();
			myCoffeeMachine.CoffeeBeansContainer.AddCoffeeBeans(50); // Adding 50g of coffee beans
			myCoffeeMachine.MakeCoffee(3); // Making 3 cups of coffee
										   // Cleaning the machine after use
			myCoffeeMachine.CleanMachine();

		}
	}
}
