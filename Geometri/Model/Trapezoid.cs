using System;

namespace Geometri.Model
{
	public class Trapezoid : Shape
	{
		private int _a, _b, _c, _d, _height;

		public Trapezoid(int a, int b, int c, int d, int height)
		{
			_a = a;
			_b = b;
			_c = c;
			_d = d;
			_height = height;
		}

		public override int Perimeter()
		{
			return _a + _b + _c + _d;
		}

		public override int Area()
		{
			return (_a + _b) * _height / 2;
		}
	}
}
