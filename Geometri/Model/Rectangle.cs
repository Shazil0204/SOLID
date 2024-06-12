namespace Geometri.Model
{
	public class Rectangle : Shape
	{
		private int _a, _b;

		public Rectangle(int a, int b)
		{
			_a = a;
			_b = b;
		}

		public override int Perimeter()
		{
			return (_a * 2) + (_b * 2);
		}

		public override int Area()
		{
			return _a * _b;
		}
	}
}
