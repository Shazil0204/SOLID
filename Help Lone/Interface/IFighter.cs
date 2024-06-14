namespace Help_Lone.Interface
{
	internal interface IFighter
	{
		int Strength { get; set; }
		void Bash();
		void Cleave();
		void Slash();
	}
}
