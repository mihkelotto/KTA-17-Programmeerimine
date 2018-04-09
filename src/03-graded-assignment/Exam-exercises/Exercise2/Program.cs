using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Sisesta lause nimedega.");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);

            string myString =
                sb
                  .Replace("kaur", "Kaur")
                  .Replace("mattias", "Mattias")
                  .Replace("kristel", "Kristel")
                  .Replace("heleri", "Heleri")
                  .Replace("trevor", "Trevor")
                  .Replace("kristjan", "Kristjan")
                  .Replace("kelli", "Kelli")
                  .Replace("kevin", "Kevin")
                  .Replace("maarika", "Maarika")
                  .Replace("laura", "Laura")
                  .ToString();

            Console.WriteLine();
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
