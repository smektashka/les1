using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели (1-7): ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(GetDayOfWeek(number));
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
        }

        static string GetDayOfWeek(int number)
        {
            switch (number)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return "";
            }
        }
    }
}