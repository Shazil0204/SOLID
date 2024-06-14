using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Lone
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}
	public interface ICharacter
	{
		/// <summary>
		/// Method in interface 1
		/// </summary>
		void ThrowMagicMisile();
		/// <summary>
		/// Method in interface 2
		/// </summary>
		void Heal();
		/// <summary>
		/// Method in interface 3
		/// </summary>
		void Die();
		/// <summary>
		/// Method in interface 4
		/// </summary>
		void ThrowFrostNova();
		/// <summary>
		/// Method in interface 5
		/// </summary>
		void RaiseShield();
		/// <summary>
		/// Method in interface 6
		/// </summary>
		void Fight();
		/// <summary>
		/// Method in interface 7
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		void Teleport(int x, int y);
		/// <summary>
		/// Method in interface 8
		/// </summary>
		void Bash();
		/// <summary>
		/// Method in interface 9
		/// </summary>
		void Cleave();
		/// <summary>
		/// Method in interface 10
		/// </summary>
		void Slash();
		/// <summary>
		/// Method in interface 11
		/// </summary>
		void ShieldGlare();
	}

	public class Wizard : ICharacter
	{
		public void Bash()
		{
			throw new NotImplementedException();
		}

		public void Cleave()
		{
			throw new NotImplementedException();
		}

		public void Die()
		{
			Console.WriteLine("I'm dying");
		}

		public void Fight()
		{
			Console.WriteLine("I'm fighting");
		}

		public void Heal()
		{
			Console.WriteLine("I'm healing");
		}

		public void RaiseShield()
		{
			throw new NotImplementedException();
		}

		public void ShieldGlare()
		{
			throw new NotImplementedException();
		}

		public void Slash()
		{
			throw new NotImplementedException();
		}

		public void Teleport(int x, int y)
		{
			Console.WriteLine("I'm teleporting to " + x + " " + y);
		}

		public void ThrowFrostNova()
		{
			Console.WriteLine("I'm throwing my frost nova");
		}

		public void ThrowMagicMisile()
		{
			Console.WriteLine("I'm throwing a magic misile");
		}
	}




	public class Babarian : ICharacter
	{
		public void Bash()
		{
			Console.WriteLine("I'm bashing someone");
		}

		public void Cleave()
		{
			Console.WriteLine("I'm cleaving someone");
		}

		public void Die()
		{
			Console.WriteLine("I'm dying");
		}

		public void Fight()
		{
			Console.WriteLine("I'm fighting");
		}

		public void Heal()
		{
			Console.WriteLine("I'm healing");
		}

		public void RaiseShield()
		{
			throw new NotImplementedException();
		}

		public void ShieldGlare()
		{
			throw new NotImplementedException();
		}

		public void Slash()
		{
			Console.WriteLine("I'm slashing someone");
		}

		public void Teleport(int x, int y)
		{
			throw new NotImplementedException();
		}

		public void ThrowFrostNova()
		{
			throw new NotImplementedException();
		}

		public void ThrowMagicMisile()
		{
			throw new NotImplementedException();
		}
	}




	public class Knight : ICharacter
	{
		public void Bash()
		{
			Console.WriteLine("I'm bashing someone");
		}

		public void Cleave()
		{
			Console.WriteLine("I'm cleaving someone");
		}

		public void Die()
		{
			Console.WriteLine("I'm dying");
		}

		public void Fight()
		{
			Console.WriteLine("I'm fighting");
		}

		public void Heal()
		{
			Console.WriteLine("I'm healing");
		}

		public void RaiseShield()
		{
			Console.WriteLine("I'm raising my shield");
		}

		public void ShieldGlare()
		{
			Console.WriteLine("I'm throwing shield glare");
		}

		public void Slash()
		{
			Console.WriteLine("I'm slashing someone");
		}

		public void Teleport(int x, int y)
		{
			throw new NotImplementedException();
		}

		public void ThrowFrostNova()
		{
			throw new NotImplementedException();
		}

		public void ThrowMagicMisile()
		{
			throw new NotImplementedException();
		}
	}



	public class Witch : ICharacter
	{
		public void Bash()
		{
			throw new NotImplementedException();
		}

		public void Cleave()
		{
			throw new NotImplementedException();
		}

		public void Die()
		{
			Console.WriteLine("I'm dying");
		}

		public void Fight()
		{
			Console.WriteLine("I'm fighting");
		}

		public void Heal()
		{
			Console.WriteLine("I'm healing");
		}

		public void RaiseShield()
		{
			Console.WriteLine("I'm raising my shield");
		}

		public void ShieldGlare()
		{
			Console.WriteLine("I'm throwing shield glare");
		}

		public void Slash()
		{
			throw new NotImplementedException();
		}

		public void Teleport(int x, int y)
		{
			Console.WriteLine("I'm teleporting to " + x + " " + y);
		}

		public void ThrowFrostNova()
		{
			throw new NotImplementedException();
		}

		public void ThrowMagicMisile()
		{
			throw new NotImplementedException();
		}
	}

}
