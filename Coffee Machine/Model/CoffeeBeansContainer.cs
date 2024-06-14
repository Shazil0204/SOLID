using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
	public class CoffeeBeansContainer
	{
		/// <summary>
		/// i made this priva
		/// </summary>
		public int CoffeeBeans { get; private set; }

		public void AddCoffeeBeans(int amount)
		{
			CoffeeBeans += amount;
			Console.WriteLine($"{amount}g of coffee beans added. Total coffee beans: {CoffeeBeans}g.");
		}

		public void UseCoffeeBeans(int amount)
		{
			if (CoffeeBeans >= amount)
			{
				CoffeeBeans -= amount;
			}
			else
			{
				throw new InvalidOperationException("Not enough coffee beans.");
			}
		}
	}
}
