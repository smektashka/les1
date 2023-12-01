using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Итог:");
            int currentNum = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNum > n)
                    {
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                Console.WriteLine();
            }
        }
    }
}