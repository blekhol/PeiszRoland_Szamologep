using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeiszRoland_Szamologep
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}

		static int Osszeadas(int a, int b)
		{
            return a + b;
        }

		static int Kivonas(int a, int b)
		{
			return a - b;
		}

		static int Szorzas(int a, int b)
		{
			return a * b;
		}

		static int Osztas(int a, int b)
		{
			return a / b;
		}

		static int Szazalek(int a, int b)
		{
			return a/b * 100;
		}

		static void Indit()
		{
			Console.WriteLine("Kérem adja meg az első számot: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Kérem adja meg a második számot: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Az elvégzendő művelet jele: ");
			string jel = Console.ReadLine().Trim();

			float ered = 0;

			switch (jel)
			{
				case "+": ered = Osszeadas(a, b); break;
				case "-": ered = Kivonas(a, b); break;
				case "*": ered = Szorzas(a, b); break;
				case "/": ered = Osztas(a, b); break;
				case "%": ered = Szazalek(a, b); break;
				default: break;
			}

			Console.WriteLine($"Az eredmény: {ered}");
		}
	}
}
