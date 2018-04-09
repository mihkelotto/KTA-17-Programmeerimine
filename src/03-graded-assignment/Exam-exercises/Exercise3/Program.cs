using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta timestampide andmed");

            Console.Write("Sisesta minimaalne aastaarv: ");
            string input = Console.ReadLine();
            int minYear = int.Parse(input);

            Console.Write("Sisesta maximaalne aastaarv: ");
            string input2 = Console.ReadLine();
            int maxYear = int.Parse(input2);
            Console.Write("Sisesta timestampide hulk: ");
            string input3 = Console.ReadLine();
            int amount = int.Parse(input3);

            Random rnd = new Random();

            string[] massiiv = new string[amount];



            for (int i = 0; i < amount; i++)
            {
                var year = rnd.Next(minYear, maxYear + 1);
                var month = rnd.Next(1, 13);
                var days = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                var hours = rnd.Next(0, 24);
                var minutes = rnd.Next(0, 60);
                var seconds = rnd.Next(0, 60);

                var born = new DateTime(year, month, days, hours, minutes, seconds);

                massiiv[i] = born.ToString();

            }

            Console.WriteLine();

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(massiiv[i]);
            }

            Console.ReadLine();
        }
    }
}
