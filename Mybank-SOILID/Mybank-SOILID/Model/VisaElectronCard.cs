using Mybank_SOILID.Model;
using System;
public class VisaElectron : DebitCard
{
	public VisaElectron(string cardHolderName) : base(cardHolderName, "4026", "417500", "4508", "4844", "4913", "4917")
	{
		ExpiryDate = DateTime.Now.AddYears(5);
	}
}