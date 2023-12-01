using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD99
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных
            Console.Write("Введите тип показа (Премьера, Обычный, Льготный): ");
            string type = Console.ReadLine();

            Console.Write("Введите количество строк в зале: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в зале: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            // Вычисление дохода
            int price;

            switch (type)
            {
                case "Премьера":
                    price = 600;
                    break;

                case "Обычный":
                    price = 410;
                    break;

                case "Льготный":
                    price = 250;
                    break;

                default:
                    Console.WriteLine("Неверный тип показа.");
                    return;
            }

            int totalIncome = price * rows * columns;

            // Вывод результата
            Console.WriteLine("Общий доход: {0} руб.", totalIncome);
        }
    }
}