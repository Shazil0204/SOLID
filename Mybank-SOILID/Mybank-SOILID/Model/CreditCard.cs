using Mybank_SOILID.Model;
using System;
public abstract class CreditCard : Card
{
	protected CreditCard(string cardHolderName, params string[] prefixes) : base(cardHolderName)
	{
		CardNumber = GenerateCardNumber(16, prefixes);
		ExpiryDate = DateTime.Now.AddYears(5);
	}
}