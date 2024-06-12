using System;

namespace Geometri.Model
{
	public class Triangle : Shape
	{
		private int _a, _b, _c;

		public Triangle(int a, int b, int c)
		{
			_a = a;
			_b = b;
			_c = c;
		}

		public override int Perimeter()
		{
			return _a + _b + _c;
		}

		public override int Area()
		{
			double s = (_a + _b + _c) / 2.0;
			return Convert.ToInt32(Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c)));
		}
	}
}
