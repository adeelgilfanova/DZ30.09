using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение.1");
            Console.WriteLine("Введите число(0<n<366): ");
            int n = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(1, 1, 1);
            Console.WriteLine($"Число {n} соответствует: {date.AddDays(n - 1).ToString("dd MMMM")} \n ");
            Console.ReadKey();

            Console.WriteLine("Упражнение.2");
            Console.WriteLine("Введите число n1: ");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 < 1 || n1 > 365)
            {
                Console.WriteLine("Вы ввели неправильное число!");
            }
            else
            {
                DateTime date1 = new DateTime(1, 1, 1);
                Console.WriteLine($"Число {n1} соответствует: {date1.AddDays(n1 - 1).ToString("dd MMMM")} \n ");
            }
            Console.ReadKey();

            Console.WriteLine("ДЗ");
            Console.WriteLine("Введите число n2: ");
            int n2 = int.Parse(Console.ReadLine());
            if (n2 < 1 || n2 > 365)
            {
                Console.WriteLine("Вы ввели неправильное число!");
            }
            else
            {
                DateTime date2 = new DateTime(1, 1, 1);
                Console.WriteLine($"Число {n2} соответствует: {date2.AddDays(n2 - 1).ToString("dd MMMM")} \n ");
                Console.WriteLine("Введите год:");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"{year} год - високосный");
                }
                else
                {
                    Console.WriteLine($"{year} год - не високосный");
                }
            }
            Console.ReadKey();

        }
    }
}   