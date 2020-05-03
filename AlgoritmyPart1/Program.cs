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
			
			int result = 0;
			int chtoVItoge;

			


			




			SimpleSearch(mass, search);
			//стр. 35-36
			Recursion(mass, 0, search);

			void SimpleSearch(string[] massa, string searcha)
			{
				if (search == massa[massa.Length - 1]) //если искомое значение совпадает с последним элементом в списке, тогда больше ничего делать не нужно и задача решена
				{
					chtoVItoge = massa.Length - 1;
					Console.WriteLine($"Искомое значение найдено и находится на {chtoVItoge} позиции");
					return;
				}

				//если искомый элемент не находится на последнем месте в списке, то сначала сохраняю последнее значение в переменную, а затем присваиваю последнему значению в массиве искомое значение, чтобы не делать на каждом этапе проверкку на достижение конца списка
				string last = mass[mass.Length - 1]; // сохранил в переменную последнее значение в массиве
				mass[mass.Length - 1] = search; //записал на последню  позицию в массиве искомое значение


				//в цикле проверяю, что что значение по идексу равно искомому, и если это не так, увеличиваю значение счетчика. Проверять массив на предмет окончания не нужно, ибо по достижению конца произойдет выход из цикла
				while (search != massa[result])
				{
					result++;
				}

				//проверяю, что найденное значение равно искомому и проверяю, что найденное значение не находится на последней позции в списке. Если это так, то получается, что значение найдено не было
				if (massa[result] == search && result < massa.Length - 1)
				{
					chtoVItoge = result;
				}
				else
				{
					chtoVItoge = -1;
				}
				Console.WriteLine((chtoVItoge == -1) ? "искомое значение найдено не было" : $"Искомое значение найдено и находится на {chtoVItoge} позиции");
			}


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
