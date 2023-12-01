using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


            int userArraySize(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }


            int[] CreateArray(int sizeArray, int low, int top)
            {
                int[] arrayForCreate = new int[sizeArray];
                Random random = new Random();

                for (int i = 0; i < sizeArray; i++)
                    arrayForCreate[i] = random.Next(low, top+1);
                return arrayForCreate;

            }


            void PrintArray(int[] arrayForPrint)
            {
                Console.WriteLine(String.Join(", ", arrayForPrint));
            }

            int size = userArraySize("Введите размер массива: ");
            int lowRange = userArraySize("Введите нижнюю границу чисел массива: ");
            int topRange = userArraySize("Введите верхнюю границу чисел массива: ");

            int[] array = CreateArray(size, lowRange, topRange);

            int[] flipArray = new int[size];
            int counter = 0;

            for(int i = 0; i < array.Length; i++)
                counter++;

            for (int i = 0; i < counter; i++)
            {
                flipArray[i] = array[counter-1 - i];
            }

            PrintArray(array);
            PrintArray(flipArray);










        }
    }
}
