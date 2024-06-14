namespace Help_Lone.Interface
{
	internal interface ICharacter
	{
		string Name { get; set; }
		int Age { get; set; }
		void Die();
        void Fight();
	}
}
