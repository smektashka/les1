using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace яв55
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод даты с консоли
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            // Проверка даты
            bool dateIsCorrect = true;

            // Проверка года на корректность
            if (year < 1)
            {
                dateIsCorrect = false;
            }

            // Проверка месяца на корректность
            if (month < 1 || month > 12)
            {
                dateIsCorrect = false;
            }

            // Проверка дня на корректность
            if (day < 1 || day > 31)
            {
                dateIsCorrect = false;
            }
            else
            {
                // Проверка количества дней в месяце
                switch (month)
                {
                    case 2: // Февраль
                        if (day > 28)
                        {
                            dateIsCorrect = false;
                        }
                        break;
                    case 4: // Апрель
                    case 6: // Июнь
                    case 9: // Сентябрь
                    case 11: // Ноябрь
                        if (day > 30)
                        {
                            dateIsCorrect = false;
                        }
                        break;
                }
            }

            // Вывод результата
            if (dateIsCorrect)
            {
                Console.WriteLine("The date is correct");
            }
            else
            {
                Console.WriteLine("The date is incorrect");
            }
        }
    }
}
