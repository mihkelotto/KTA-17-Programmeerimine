using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double number = 0;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("------------------------------------------------------------");

            while (true)
            {

                Console.Write("Enter price of food item [-1 to quit]: ");

                string numberStr = Console.ReadLine();
                double userNumber = double.Parse(numberStr);

                if (!(userNumber == -1)) {

                    number = userNumber + number;

                }

                else
                {
                    break;
                }

            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Subtotal : €{Math.Round(number, 2)}");
            Console.WriteLine($"15% Gratity : €{Math.Round((number * 0.15), 2)}");
            Console.WriteLine($"Total : €{Math.Round((number - (number * 0.15)), 2)}");

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
