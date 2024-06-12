using Mybank_SOILID.Model;
using System;
public class Maestro : DebitCard
{
	public Maestro(string cardHolderName) : base(cardHolderName, "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763")
	{
		ExpiryDate = DateTime.Now.AddYears(5).AddMonths(8);
	}
}