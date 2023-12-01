using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                // Выводим пробелы перед числами в каждой строке (чтобы создать пирамидальный вид)
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");
                }

                // Выводим числа в каждой строке
                for (int k = 0; k < i; k++)
                {
                    Console.Write("{0} ", number);
                    number++;
                }

                Console.WriteLine();
            }
        }
    }
}