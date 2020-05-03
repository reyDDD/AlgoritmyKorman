using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mass = new int[] { 3, 5, 8, 12, 67, 76, 87, 94 };
			int searchData = 74;

			try
			{
				int? itog = BinarSearch(mass, 0, mass.Length - 1, searchData);
				Console.WriteLine($"Значение {itog} найдено в массиве, где оно находится по индексу {Array.BinarySearch(mass, itog)}");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
		}

		static int? BinarSearch(int[] mass, int indexStart, int indexEnd, int searchData)
		{
			int[] massiv = mass;
			int itog = -1;

			while (true)
			{
				//если в коллекции остался один элемент, проверяю, что он не равен искомому
				if (massiv.Length == 1)
				{
					if (massiv[0] != searchData)
					{
						throw new Exception("Значение в списке не найдено");
					}
				}
				//проверяю, что в коллекции еще есть данные
				if (massiv[indexStart] > massiv[massiv.Length - 1])
				{
					throw new Exception("Значение в списке не найдено");
				}
				else if (massiv[indexStart] <= massiv[massiv.Length - 1])
				{
					int plato = (massiv.Length - 1 - indexStart) / 2;
					if (massiv[plato] == searchData)
					{
						itog = massiv[plato];
						return itog;
					}
					else if (massiv[plato] > searchData)
					{
						int[] massa = new int[massiv.Length - (plato + 1)];
						Array.Copy(massiv, massa, plato + 1);
						massiv = massa;
					}
					else if (massiv[plato] < searchData)
					{
						int[] massa = new int[massiv.Length - (plato + 1)];
						Array.Copy(massiv, plato + 1, massa, 0, massiv.Length - (plato + 1));
						massiv = massa;
					}
				}
			}
		}

	}
}
