using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_three
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            List<string> words = new List<string>();

            while (true)
            {
                Console.WriteLine("Sisesta sõna: ");
                month = Console.ReadLine();

                if(month == "-1")
                {
                    break;
                }

                words.Add(month);

            }

            Console.WriteLine($"Sisestasid s6nad: {string.Join(", ", words)}");

            var randomIndex = new Random().Next(0, words.Count - 1);

            Console.WriteLine($"Valin nendest välja suvaise: {words[randomIndex]}");

            Console.ReadLine();
        }
    }
}
