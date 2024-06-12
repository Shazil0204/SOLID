using System;

namespace Geometri.View
{
	internal class ShowResult
	{
		public void ShowArea(int returnValue, string name)
		{
            Console.WriteLine("The area of " + name + " is: " + returnValue);
        }
		public void ShowPerimeter(int returnValue, string name)
		{
			Console.WriteLine("The perimeter of " + name + " is: " + returnValue);
		}
	}
}
