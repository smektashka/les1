using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 65, 30, 2, 6, 17, 83, 99, 8, 12, 91 };

            var sortedNumbers = mass.OrderBy(x => x);

            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
