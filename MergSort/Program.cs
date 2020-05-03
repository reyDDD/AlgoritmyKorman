using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergSort
{
    class Program
    {
        //метод для слияния массивов
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            int[] tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            //сравниваю первое непроверенное значение с левой стороны с первым непроверенным значением с правой стороны, и вношу меньшее значение по индексу вов времнный массив, затем увеличиваю этот индекс для временного массива
            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            //тут в двух циклах проверяю, что у меня не осталось данных после сравнения правой и левой стороны. Если они остались, они дописываются по порядку в конец временного списка. 
            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            //на третьем этапе переношу в базовый список данные из временного, начиная с указанного индекса
            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        //сортировка слиянием
        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }


        static void Main(string[] args)
        {

            var array = new int[] { 12, 43, 3};


            Console.WriteLine("Упорядоченный массив: {0}", MergeSort(array));

            Console.ReadLine();
        }
    }
}
