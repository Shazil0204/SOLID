using Mybank_SOILID.Model;
public class WithdrawalCard : Card
{
	public WithdrawalCard(string cardHolderName) : base(cardHolderName)
	{
		CardNumber = GenerateCardNumber(16, "2400");
	}
}