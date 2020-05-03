using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//стр. 50 нихуя это дерьмо не работает, на фиг
namespace SortMerge
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mass = new int[] { 33, 15, 98, 12, 671, 76, 87, 94 };

			var result = Sorting(mass);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}



		}
		static int[] Sorting(int[] mass)
		{
			return WorkRecursion(mass, 0, mass.Length - 1);
		}

		static int[] WorkRecursion(int[] mass, int min, int max)
		{

			if (min< max)
			{
				int plato = (min + max) / 2;
				WorkRecursion(mass, min, plato);
				WorkRecursion(mass, plato+1, max); 
			}
			return mass;
		}
		static int[] Merge(int[] mass1, int[] mass2)
		{
			int[] mass = new int[mass1.Length + mass2.Length];
			int y = 0;
			int u = 0;
			for (int i = 0; i < mass.Length; i++)
			{
				if (y < mass1.Length && u < mass2.Length && mass1[y] > mass2[u])
				{
						mass[i] = mass2[u];
						u++;
				}
				else if (y < mass1.Length && u < mass2.Length && mass1[y] < mass2[u])
				{
					mass[i] = mass1[y];
					y++;
				}
				else if (y >= mass1.Length && u < mass2.Length)
				{
					mass[i] = mass2[u];
					u++;
				}
				else if (u >= mass2.Length && y < mass1.Length)
				{
					mass[i] = mass1[y];
					y++;
				}

			}
			return mass;
		}
	}
}
