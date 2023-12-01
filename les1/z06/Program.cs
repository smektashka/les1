using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd66
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k <= ('a' + l - 1); k++)
                    {
                        for (char m = 'a'; m <= ('a' + l - 1); m++)
                        {
                            for (int p = Math.Max(i, j) + 1; p <= 9; p++)
                            {
                                Console.Write($"{i}{j}{k}{m}{p} ");
                            }
                        }
                    }
                }
            }
        }
    }
}