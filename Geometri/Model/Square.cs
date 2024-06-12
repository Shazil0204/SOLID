using System;

namespace Geometri.Model
{
	public class Square : Shape
	{
		private int _a;

		public Square(int a)
		{
			_a = a;
		}

		public override int Perimeter()
		{
			return _a * 4;
		}

		public override int Area()
		{
			return _a * _a;
		}
	}
}
