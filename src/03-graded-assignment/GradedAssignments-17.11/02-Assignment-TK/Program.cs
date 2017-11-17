using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Assignment_TK
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            double number = 0; ;

            Console.WriteLine("-----------------------------------------------------------");

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");

                string input = Console.ReadLine();

                double userNumber = double.Parse(input);

                if (!(userNumber == -1))
                {
                    number = userNumber + number;
                }

                if(userNumber == -1)
                {
                    break;
                }
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine($"Subtotal : €{number}");
            Console.WriteLine($"15% Gratity : €{number * 0.15}");
            Console.WriteLine($"Total : €{number - (number * 0.15)}");

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
