using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Sisesta nimesid. Lõpetamiseks sisesta -1");

            ArrayList list = new ArrayList();
            while (true)
            {
                Console.Write("Sisesta nimi: ");
                string input = Console.ReadLine();
                string rightInput = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
                if (input == "-1")
                {
                    break;
                }
                list.Add(rightInput);
            }

            Console.WriteLine();

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
