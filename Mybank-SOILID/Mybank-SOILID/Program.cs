using Mybank_SOILID.Model;
using System;

namespace MyBanker
{
	class Program
	{
		static void Main(string[] args)
		{
			Card haevekort = new WithdrawalCard("Peter Hansen");
			Card maestro = new Maestro("Peter Hansen");
			Card visaElectron = new VisaElectron("Peter Hansen");
			Card visaDankort = new VisaDankort("Peter Hansen");
			Card mastercard = new Mastercard("Peter Hansen");

			Console.WriteLine(haevekort);
			Console.WriteLine(maestro);
			Console.WriteLine(visaElectron);
			Console.WriteLine(visaDankort);
			Console.WriteLine(mastercard);
			Console.ReadKey();
		}
	}
}
