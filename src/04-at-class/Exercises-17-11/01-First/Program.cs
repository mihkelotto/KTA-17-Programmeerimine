using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_First
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello world");
            int input = GetUserInput();

            Console.WriteLine($"Hello {input}!");

         //   string n = "Kristjan";
          //  string n2 = "Toomas";
          //  string n3 = "Maarja";

          //  PrintGreeting(n, n2, n3); 

            Console.WriteLine("Press any key to continue");

            Console.ReadKey();

        }

        static int GetUserInput()
        {
            bool succes = true;

            int value = 0;

            while(succes)
            {
                string input = Console.ReadLine();

                succes = !int.TryParse(input, out value);

            }

            return value;
        }

        static void PrintGreeting(string name, string name2, string name3)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine($"Hey {name}");
            Console.WriteLine($"Hey {name2}");
            Console.WriteLine($"Hey {name3}");
        }

        static void DoSomething()
        {

        }
    }
}
