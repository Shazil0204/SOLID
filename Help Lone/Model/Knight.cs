using Help_Lone.Interface;

namespace Help_Lone.Model
{
	internal class Knight: Character, IFighter, IGender
	{
		public int Strength { get; set; }
		public bool IsMale { get; set; }
		public Knight(string name, int age, int strength, bool isMale) : base(name, age)
		{
			Strength = strength;
			IsMale = isMale;
		}
		public void Bash()
		{

		}
		public void Cleave()
		{

		}
		public void Slash()
		{

		}
		public override void Die()
		{

		}
		public override void Fight()
		{

		}
	}
}