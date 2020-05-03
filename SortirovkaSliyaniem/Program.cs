using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortirovkaSliyaniem
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mass = new int[] { 12, 21, 54, 1, 5, 9, 28 };
			foreach (var item in mass)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			var result = MergeSorting(mass);
			foreach (var item in result)
			{
				Console.Write(item + " ");
			}
		}

		private static int[] MergeSorting(int[] mass)
		{
			return MergeSorting(mass, 0, mass.Length - 1);
		}

		private static int[] MergeSorting(int[] mass, int min, int max)
		{
			if (min < max)
			{
				int plato = (min + max) / 2;
				MergeSorting(mass, min, plato);
				MergeSorting(mass, plato + 1, max);
				Work(mass, min, plato, max);
			}
			return mass;
		}

		private static void Work(int[] mass, int min, int plato, int max)
		{
			int left = min;
			int right = plato + 1;
			int[] posrednik = new int[max - min + 1];
			int index = 0;

			//выношу наименьшие данные в список, пока не доберуть от лефта до плато или от райта до конца массива
			while (left <= plato && right <= max)
			{
				if (mass[left] < mass[right])
				{
					posrednik[index] = mass[left];
					left++;
				}
				else
				{
					posrednik[index] = mass[right];
					right++;
				}
				index++;
			}


			//далее добиваю временный список теми значениями, которые остались слева или справа от конечной точки каждой половины
			for (int i = left; i <= plato; i++)
			{
				posrednik[index] = mass[left];
			}
			for (int i = right; i <= max; i++)
			{
				posrednik[index] = mass[right];
			}

			//третий шаг - переписываю из временного списка в основной
			for (int i = 0; i < posrednik.Length; i++)
			{
				mass[min + i] = posrednik[i];
			}
		}
	}
}
