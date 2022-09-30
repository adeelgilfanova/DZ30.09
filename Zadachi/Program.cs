using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    public enum DayOfWeek
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 3,
        Четверг = 4,
        Пятниццо = 5,
        Суббота = 6,
        Воскресенье = 7
    }
    class Program
    {
        public static void Bubble_Sort(int[] anArray)
        {
            //Выводим элементы массива (массив в исходном виде)
            PrintArray(anArray);

            for (int i = 0; i < anArray.Length; i++)
            {
                //(количество повторений, равно количеству элементов массива минус 1 и минус количество выполненных повторений основного цикла)
                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {
                    //Если элемент массива с индексом j больше следующего за ним элемента
                    if (anArray[j] > anArray[j + 1])
                    {
                        //Меняем местами элемент массива с индексом j и следующий за ним
                        Swap(ref anArray[j], ref anArray[j + 1]);
                    }
                }

                //Выводим элементы массива после очередной операции
                PrintArray(anArray);
            }
        }

        //Метод, "меняет местами" два элемента
        public static void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            //Вспомогательная переменная, хранит значение первого элемента
            int tmpParam = aFirstArg;

            //Первый аргумент получил значение второго
            aFirstArg = aSecondArg;

            //Второй аргумент, получил сохраненное ранее значение первого
            aSecondArg = tmpParam;
        }

        //Вспомогательный метод, выводящий на консоль элементы массива
        public static void PrintArray(int[] anArray)
        {
            //Перебор всех элементов массива
            for (int i = 0; i < anArray.Length; i++)
            {
                //Вывод значения текущего элемента и пробел после него
                Console.Write(anArray[i] + " ");
            }

            //Перевод строки
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1 ");
            Console.WriteLine("Введите сторону а: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы Васи d: ");
            double d = double.Parse(Console.ReadLine());
            if (a - d >= 2)
            {
                if (b - d >= 2)
                {
                    Console.WriteLine("Голова Васи пролезет\n!");
                }
                else if (b - d < 2)
                {
                    Console.WriteLine("Голова Васи не пролезет\n!");
                }
            }
            else
            {
                Console.WriteLine("Голова Васи не пролезет!\n");
            }
            Console.ReadKey();

            Console.WriteLine("Задача 2");
            Console.WriteLine("Введите число 1<=n<=9: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Таблица умножения числа {n}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n}*{i}={n * i} \n");
            }
            Console.ReadKey();

            Console.WriteLine("Задача 3");
            Console.WriteLine("Введите число: ");
            int chislo = int.Parse(Console.ReadLine());
            if (chislo % 3 == 0 && chislo % 5 != 0)
            {
                Console.WriteLine("Бэнг\n");
            }
            else if (chislo % 5 == 0 && chislo % 3 != 0)
            {
                Console.WriteLine("Бум\n");
            }
            else if (chislo % 3 == 0 && chislo % 5 == 0)
            {
                Console.WriteLine("БэнгБум\n");
            }
            else
            {
                Console.WriteLine("Мимо\n");
            }
            Console.ReadKey();

            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            int pr = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str.ToUpper()[i])
                {
                    pr = 1;
                }
                else
                    pr = 0;
            }
            if (pr == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();

            Console.WriteLine("\n Задача 5");
            Console.WriteLine("Введите любое целое положительное число: ");
            int chislo1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= chislo1; i++)
            {
                Console.WriteLine($"{i} овца...");
            }
            Console.ReadKey();

            Console.WriteLine("\n Задача 6");
            try
            {
                Console.WriteLine("Введите число элементов массива: ");
                int n1 = int.Parse(Console.ReadLine());
                int[] massOFn = new int[n1];
                int i1 = 0;
                int sum = 0;
                while (i1 < n1)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    massOFn[i1] = int.Parse(Console.ReadLine());
                    i1++;
                }
                for (int i = 0; i < (massOFn.Length - 1); i++)
                {
                    massOFn[i] = i + 1;
                    sum += massOFn[i];
                }
                int srArifm;
                srArifm = sum / massOFn.Length;
                Console.WriteLine($"Среднее арифметическое чисел = {srArifm}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста введите число!");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!");
            }
            Console.ReadLine();

            Console.WriteLine("\n Задача 7");
            try
            {
                Console.WriteLine("Введите номер карты: ");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 6:
                        Console.WriteLine("Шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Семерка");
                        break;
                    case 8:
                        Console.WriteLine("Восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                    default:
                        Console.WriteLine("Введите номер в диапазоне от 6 до 14!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите пожалуйста число!");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!");
            }
            Console.ReadKey();

            Console.WriteLine("\n Задача 8");
            string[] kykla = { "Hagi-vagi", "Kissi-missi", "Hello Kitty", "Barbie doll", "Bratz", "Hagi-vagi", "Kissi-missi", "Hello Kitty", "Barbie doll", "Bratz", "Hagi-vagi", "Kissi-missi", "Hello Kitty", "Barbie doll", "Bratz" };
            int bag = 0;
            foreach (string q in kykla)
            {
                if (q == "Hello Kitty" || q == "Barbie doll")
                {
                    bag++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке: {bag}");
            Console.ReadKey();

            Console.WriteLine("\n Задача 9");
            Console.WriteLine("Введите номер: ");
            var numb = int.Parse(Console.ReadLine());
            Console.WriteLine((DayOfWeek)((numb)));

            Console.WriteLine("\n Задача 10");
            // массив целых чисел, который нужно отсортировать 
            int[] someArray = new int[] {2,-3,0,15,36,-4,24,5 };
            //Сортируем его 
            Bubble_Sort(someArray); 
            Console.ReadKey();

            Console.WriteLine("\n Задача 11");
            Console.WriteLine("Введите последовательность: ");
            string chisla=Console.ReadLine();
            for (int i=0; i<chisla.Length-1;i++)
            {
                if (chisla[i] > chisla[i+1])
                {
                    Console.WriteLine("Последовательность не возрастающая! Индекс нарушающего числа={0}",i+1);
                    break;
                }
            }
            Console.ReadKey();
        }       
    }
}
