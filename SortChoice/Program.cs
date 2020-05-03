using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortChoice
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mass = new int[] { 33, 15, 98, 12, 671, 76, 87, 94 };
			for (int i = 0; i < mass.Length - 1; i++)
			{
				int smallest = default;
				for (int j = i + 1; j < mass.Length; j++)
				{
					if (mass[j] < mass[i])
					{
						smallest = mass[j];
						mass[j] = mass[i];
						mass[i] = smallest;
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
