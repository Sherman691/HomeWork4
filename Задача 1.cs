using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая бесконечно запрашивает целые числа с консоли.
            //Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

            string Reader(string text)
            {
                Console.Write(text);
                return Console.ReadLine();
            }

            
            

            string quit = Reader("Введите символ который будет завершать программу: ");
            string userInput = Reader($"Введите число, или введите {quit} для выхода: ");

            while (true)
            {
                if (userInput == quit) break;

                int number;
                if (int.TryParse(userInput, out number))
                {
                    int sum = 0;
                    while (number > 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("[STOP]");
                        break;
                    }
                    userInput = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Некорректный ввод! Введите цело число или {quit}");
                    userInput = Console.ReadLine();
                }
            }


        }
    }
}
