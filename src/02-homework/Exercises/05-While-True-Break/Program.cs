using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_While_True_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            Console.WriteLine();

            Random rnd = new Random();

            int computerNumber = rnd.Next(1, 101);

            while (true) {

                Console.Write("Sisesta number: ");

                string input = Console.ReadLine();

                int userNumber = int.Parse(input);

                if (userNumber < computerNumber)
                {
                    Console.WriteLine($"Sinu sisestatud number {userNumber} on väiksem arvuti omast.");
                }

                if (userNumber > computerNumber)
                {
                    Console.WriteLine($"Sinu sisestatud number {userNumber} on suurem arvuti omast.");
                }

                if (userNumber == computerNumber)
                {
                    Console.WriteLine("Arvasid numbri ära");
                    break;
                }

            }

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
