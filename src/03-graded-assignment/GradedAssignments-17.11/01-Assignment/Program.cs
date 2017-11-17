using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Sisesta number: ");

            string input = Console.ReadLine();

            int userNumber = int.Parse(input);

            Console.WriteLine(userNumber);

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
