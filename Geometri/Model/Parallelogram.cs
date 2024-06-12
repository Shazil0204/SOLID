using System;

namespace Geometri.Model
{
	public class Parallelogram : Shape
	{
		private int _a, _b, _angle;

		public Parallelogram(int a, int b, int angle)
		{
			_a = a;
			_b = b;
			_angle = angle;
		}

		public override int Perimeter()
		{
			return 2 * (_a + _b);
		}

		public override int Area()
		{
			return Convert.ToInt32(_a * _b * Math.Sin(_angle * Math.PI / 180));
		}
	}
}
