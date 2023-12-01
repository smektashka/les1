using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd110
{
    public class Program
    {
        public static void Main()
        {
            // Пример ввода числа и индекса
            int number = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine()); 
            
            FindNthDigit(number, index);
        }

        public static void FindNthDigit(int number, int index)
        {
            int count = 1;
            while (number != 0)
            {
                int digit = number % 10;
                if (count == index)
                {
                    Console.WriteLine(digit);
                    break;
                }

                number = number / 10;
                count++;
            }
        }
    }
}
