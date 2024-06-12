using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybank_SOILID.Model
{
	public abstract class Card
	{
		protected static Random random = new Random();
		public string CardNumber { get; protected set; }
		public string AccountNumber { get; protected set; }
		public string CardHolderName { get; protected set; }
		public DateTime? ExpiryDate { get; protected set; }

		protected Card(string cardHolderName)
		{
			CardHolderName = cardHolderName;
			AccountNumber = GenerateAccountNumber();
		}

		protected string GenerateAccountNumber()
		{
			return "3520" + random.Next(10000000, 999999999).ToString();
		}

		protected string GenerateCardNumber(int length, params string[] prefixes)
		{
			string prefix = prefixes[random.Next(prefixes.Length)];
			int randomLength = length - prefix.Length;
			string randomPart = random.Next((int)Math.Pow(10, randomLength - 1), (int)Math.Pow(10, randomLength)).ToString();
			return prefix + randomPart;
		}

		public override string ToString()
		{
			return $"Card Holder: {CardHolderName}, Card Number: {CardNumber}, Account Number: {AccountNumber}, Expiry Date: {ExpiryDate?.ToString("MM/yyyy") ?? "None"}";
		}
	}
}
