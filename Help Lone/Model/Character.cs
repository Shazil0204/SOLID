using Help_Lone.Interface;

namespace Help_Lone.Model
{
	internal abstract class Character: ICharacter
	{

		public string Name { get; set; }
		public int Age { get; set; }

		private protected Character(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public abstract void Die();


		public abstract void Fight();
	}
}
