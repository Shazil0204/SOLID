using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
	public class WaterContainer
	{
		public int WaterLevel { get; private set; }

		public void AddWater(int amount)
		{
			WaterLevel += amount;
			Console.WriteLine($"{amount}ml of water added. Total water: {WaterLevel}ml.");
		}

		public void UseWater(int amount)
		{
			if (WaterLevel >= amount)
			{
				WaterLevel -= amount;
			}
			else
			{
				throw new InvalidOperationException("Not enough water.");
			}
		}
	}
}
