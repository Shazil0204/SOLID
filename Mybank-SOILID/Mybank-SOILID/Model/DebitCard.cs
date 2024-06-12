using Mybank_SOILID.Model;
public abstract class DebitCard : Card
{
	protected DebitCard(string cardHolderName, params string[] prefixes) : base(cardHolderName)
	{
		CardNumber = GenerateCardNumber(16, prefixes);
	}
}