using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmyPart1
{
	class Program
	{
		static void Main(string[] args)
		{
			//стр. 23-28 (глава 2)
			string[] mass = { "один", "два", "три" };
			string search = "три";
			int dlina = mass.Length - 1;
			string last = mass[dlina];
			mass[dlina] = "три";
			int result = 0;
			int chtoVItoge;

			while (search != mass[result])
			{
				result++;
			}

			if (mass[result] == last || result < mass.Length - 1)
			{
				chtoVItoge = result;
			}
			else
			{
				chtoVItoge = -1;
			}
			Console.WriteLine(chtoVItoge);


			//стр. 35-36
			Recursion(mass, 0, search);

			void Recursion(string[] massiv, int position, string znachenie)
			{
				if (massiv[position] == znachenie)
				{
					Console.WriteLine($"задача с помощью рекурсии решена, индекс искомого значения - {position}");

				}
				else if (position < massiv.Length)
				{
					Recursion(massiv, position + 1, znachenie);
				}

			}


		}
	}
}
