using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> /roll 3d6 2d8 ");
            Console.WriteLine();

            Dice dice = new Dice();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(dice.Roll(6));
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(dice.Roll(8));
            }

            var random = new Random();
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                var roll = random.Next(1, 7);
                sum += roll;
                Console.WriteLine($"1d6: {roll}");
            }

            for (int i = 0; i < 2; i++)
            {
                var roll = random.Next(1, 9);
                sum += roll;
                Console.WriteLine($"1d8: {roll}");
            }

            Console.WriteLine();
            Console.WriteLine($"Roll total: {sum}");
            Console.WriteLine();
            Console.WriteLine("> ");

            Console.ReadLine();

        }
    }
}
