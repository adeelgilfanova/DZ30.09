using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{

    class Program
    {
        private static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            return today.Year - birthDate.Year - 1 +((today.Month > birthDate.Month || today.Month == birthDate.Month && today.Day >= birthDate.Day) ? 1 : 0);
        }
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(2004, 5, 26);
            int age = CalculateAge(birthDate);
            Console.WriteLine("{0}", age);
        }
    }
}
