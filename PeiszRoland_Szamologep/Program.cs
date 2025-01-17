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
			Indit();

			Console.ReadKey();
		}

		static float Osszeadas(float a, float b)
		{
            return a + b;
        }

		static float Kivonas(float a, float b)
		{
			return a - b;
		}

		static float Szorzas(float a, float b)
		{
			return a * b;
		}

		static float Osztas(float a, float b)
		{
			return a / b;
		}

		static float Szazalek(float a, float b)
		{
			return a/b * 100;
		}


		static void Indit()
		{
			Console.WriteLine("Kérem adja meg az első számot: ");
			float a = float.Parse(Console.ReadLine());
			Console.WriteLine("Kérem adja meg a második számot: ");
			float b = float.Parse(Console.ReadLine());
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
