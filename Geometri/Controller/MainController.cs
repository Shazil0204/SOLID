using System;
using System.Collections.Generic;
using System.Threading;
using Geometri.View;
using Geometri.Model;

namespace Geometri.Controller
{
	public class MainController
	{
		Messages message = new Messages();
		ShowResult showResult = new ShowResult();
		AskInformation AskInfo = new AskInformation();
		private sbyte _option;
		private List<Shape> shapes = new List<Shape>(); // List to store shapes

		public void AllControllerCombiner()
		{
			message.StartProgram();
			_option = AskInfo.SelectOption();
			SelectTask();
		}

		public void SelectTask()
		{
			while (true)
			{
				try
				{
					// This is for Square area and perimeter
					message.AskSquareValue();
					int squareValue = AskInfo.Value();
					Square square = new Square(squareValue);
					shapes.Add(square); // Add to list
					showResult.ShowArea(square.Area(), "square");
					showResult.ShowPerimeter(square.Perimeter(), "square");

					// This is for rectangle area and perimeter
					message.AskRectangleValueA();
					int rectangleValueA = AskInfo.Value();
					message.AskRectangleValueB();
					int rectangleValueB = AskInfo.Value();
					Rectangle rectangle = new Rectangle(rectangleValueA, rectangleValueB);
					shapes.Add(rectangle); // Add to list
					showResult.ShowArea(rectangle.Area(), "rectangle");
					showResult.ShowPerimeter(rectangle.Perimeter(), "rectangle");

					// This is for parallelogram area and perimeter
					message.AskParallelogramValueA();
					int parallelogramValueA = AskInfo.Value();
					message.AskParallelogramValueB();
					int parallelogramValueB = AskInfo.Value();
					message.AskParallelogramAngle();
					int parallelogramAngle = AskInfo.Value();
					Parallelogram parallelogram = new Parallelogram(parallelogramValueA, parallelogramValueB, parallelogramAngle);
					shapes.Add(parallelogram); // Add to list
					showResult.ShowArea(parallelogram.Area(), "parallelogram");
					showResult.ShowPerimeter(parallelogram.Perimeter(), "parallelogram");

					// This is for trapezoid area and perimeter
					message.AskTrapezoidSideA();
					int trapezoidSideA = AskInfo.Value();
					message.AskTrapezoidSideB();
					int trapezoidSideB = AskInfo.Value();
					message.AskTrapezoidHeight();
					int trapezoidHeight = AskInfo.Value();
					Trapezoid trapezoid = new Trapezoid(trapezoidSideA, trapezoidSideB, trapezoidHeight, 2, 2);
					shapes.Add(trapezoid); // Add to list
					showResult.ShowArea(trapezoid.Area(), "trapezoid");
					showResult.ShowPerimeter(trapezoid.Perimeter(), "trapezoid");

					// This is for triangle area and perimeter
					message.AsktriangleSideA();
					int triangleSideA = AskInfo.Value();
					message.AsktriangleSideB();
					int triangleSideB = AskInfo.Value();
					message.AsktriangleSideC();
					int triangleSideC = AskInfo.Value();
					Triangle triangle = new Triangle(triangleSideA, triangleSideB, triangleSideC);
					shapes.Add(triangle); // Add to list
					showResult.ShowArea(triangle.Area(), "triangle");
					showResult.ShowPerimeter(triangle.Perimeter(), "triangle");

					// Optional: Display all collected shapes
					DisplayAllShapes();
				}
				catch
				{
					message.CatchMessage();
				}
				Thread.Sleep(5000);
				Console.Clear();
				AllControllerCombiner();
			}
		}

		private void DisplayAllShapes()
		{
			foreach (var shape in shapes)
			{
				Console.WriteLine($"Shape: {shape.GetType().Name}, Perimeter: {shape.Perimeter()}, Area: {shape.Area()}");
			}
		}
	}
}
