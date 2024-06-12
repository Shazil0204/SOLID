using System;

namespace Geometri.View
{
	public class Messages
	{
		public void StartProgram()
		{
            Console.WriteLine("Welcome To Solid Program please choose one of the following options: (Just type the number of the option. Thanks!)");
			Console.WriteLine("1. Perimeter of Square");
			Console.WriteLine("2. Perimeter of Rectangle");
			Console.WriteLine("3. Area of parallelogram");
			Console.WriteLine("4. Area of Trapezoid");
        }
		public void AreaOrPerimeter()
		{
            Console.WriteLine("Please select one of the followings:");
            Console.WriteLine("1. Area");
			Console.WriteLine("2. Perimeter;");
        }	
		public void ErrorMessage()
		{
			Console.WriteLine("Sorry Something went wrong please try again. Thanks!");
		}
		public void CatchMessage()
		{
			Console.WriteLine("Something NOT Virker Only Catch Virker You try again. Arigato Gozaimasu!");
		}
		public void AskSquareValue()
		{
			Console.Write("Please insert the Square side length: \t");
		}
		public void AskRectangleValueA()
		{
			Console.Write("Please insert the rectangle length: \t");
		}
		public void AskRectangleValueB()
		{
			Console.Write("Please insert the rectangle width: \t");
		}
		public void AskParallelogramValueA()
		{
            Console.Write("Please insert the parallelogram length: \t");
		}
		public void AskParallelogramValueB()
		{
            Console.Write("Please insert the parallelogram width: \t");
        }
		public void AskParallelogramAngle()
		{
            Console.Write("Please insert the angle of parallelgram");
        }
		public void AskTrapezoidSideA()
		{
            Console.Write("Please insert the Trapezoid side a: \t");
		}
		public void AskTrapezoidSideB()
		{
            Console.Write("Please insert the Trapezoid side b: \t");
		}
		public void AskTrapezoidHeight()
		{
            Console.Write("Please insert the Trapezoid height: \t");
		}
		public void AsktriangleSideA()
		{
            Console.Write("Please insert the Trapezoid side A: \t");
		}
		public void AsktriangleSideB()
		{
            Console.Write("Please insert the Trapezoid side B: \t");
		}
		public void AsktriangleSideC()
		{
			Console.Write("Please insert the Trapezoid side C: \t");
		}
	}
}
