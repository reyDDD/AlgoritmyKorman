using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortInserted
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mass = new int[] { 33, 15, 98, 12, 671, 76, 87, 94 };

			for (int i = 1; i < mass.Length; i++)
			{
				int chranitel = mass[i];

				for (int j = i - 1; j >= 0; j--)
				{
					if (mass[j] > chranitel)
					{
						mass[j+1] = mass[j];
						mass[j] = chranitel;
					}
				}
					
			}

			foreach (var item in mass)
			{
				Console.WriteLine(item);
			}
		}
	}
}
