using Help_Lone.Interface;

namespace Help_Lone.Model
{
	internal class Wizard: Character, IMage, ITeleporter, IHealer
	{
		public int Mana {  get; set; }
		public int MaxMana { get; set; }

		public Wizard(string name, int age): base(name, age)
		{

		}

		public void Teleport(int x, int y)
		{

		}
		public void Heal()
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
