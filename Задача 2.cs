using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте массив заполненный случайными трёхзначными числами.
            //Напишите программу, которая покажет количество чётных чисел в массиве.

            int userArraySize(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }


            int[] CreateArray(int sizeArray,int low = 100, int top = 1000)
            {
                int[] arrayForCreate = new int[sizeArray];
                Random random = new Random();

                for(int i = 0; i < sizeArray; i++)
                     arrayForCreate[i] = random.Next(low, top);
                return arrayForCreate;

            }


            void PrintArray(int[] arrayForPrint)
            {
                for (int i = 0; i < arrayForPrint.Length; i++)
                Console.Write(arrayForPrint[i] + ", ");
                Console.WriteLine();
            }

            int size = userArraySize("Введите размер массива: ");

            int[] array = CreateArray(size);
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 0) sum++;
            }

            PrintArray(array);
            Console.Write(sum);
            Console.WriteLine();
          
        }
    }
}
