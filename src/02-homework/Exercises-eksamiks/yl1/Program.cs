using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yl1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimesid. Lõpetamiseks sisesta -1");

            ArrayList list = new ArrayList();
            while(true)
            {
                Console.WriteLine("Sisesta nimi: ");
                string input = Console.ReadLine();
                string rightInput = input.First().ToString().ToUpper() + input.Substring(1);
                if (input == "-1")
                {
                    break;
                }
                list.Add(rightInput);
            }

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press aby key to continue.");
            Console.ReadLine();
        }
    }
}
