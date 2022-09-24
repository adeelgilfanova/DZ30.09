using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    enum Types
    {
        Текущий,
        Сберегательный
    }

    struct Bank
    {
        public int number;
        public string type;
        public string balance;

        public Bank(int number, string type, string balance)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
        }
        public void Print()
        {
            Console.WriteLine($"Номер: {number}, Тип: {type}, Баланс:{balance}");
        }
    }
    enum Vus
    {
        КГУ,
        КАИ,
        КХТИ
    }

    struct Worker
    {
        public string name;
        public int vuz;

        public Worker(string name, int vuz)
        {
            this.name = name;
            this.vuz = vuz;
        }
        public void Print1()
        {
            Console.WriteLine($"Имя: {name}, Вуз: {vuz}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение1");
            Types credit = Types.Текущий;
            Types credit1 = Types.Сберегательный;
            Console.WriteLine("Тип - {0}, номер - {1}", credit, (int)credit);
            Console.WriteLine("Тип - {0}, номер - {1}", credit1, (int)credit1);

            Console.WriteLine("Упражнение2");
            Bank bank = new Bank();
            bank.number = 101234;
            bank.type = "Текущий";
            bank.balance = "234560000$";
            bank.Print();

            Console.WriteLine("Домашняя работа1");
            Vus Vuz1 = Vus.КГУ;
            Vus Vuz2 = Vus.КАИ;
            Vus Vuz3 = Vus.КХТИ;
            Worker worker0 = new Worker("Василий", (int)Vuz1);
            worker0.Print1();
            Worker worker1 = new Worker("Николай", (int)Vuz2);
            worker1.Print1();
            Worker worker2 = new Worker("Петрович", (int)Vuz3);
            worker2.Print1();
            Console.WriteLine("КАИ-0, КХТИ-1 ,КГУ-2");
            Console.ReadKey();
        }
    }
}