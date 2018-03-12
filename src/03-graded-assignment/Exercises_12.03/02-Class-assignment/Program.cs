using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Class_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("krüptimise ja dekrüptimise programm");
            Console.WriteLine("Krüptimiseks vajutage: 1");
            Console.WriteLine("Dekrütimiseks vajutage 2");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                //var text = Console.ReadLine();

                string raw = "abc";
                string encrypted = "";

                for (int i = 0; i < encrypted.Length; i++)
                {
                    var asciiCode = (int)raw[i];
                    var crypted = asciiCode + 3;
                    encrypted += (char)crypted;
                    //if(raw[i] == "a")
                 //   {

                  //  }
                }

            }

            else if (key.Key == ConsoleKey.D2)
            {
                Console.WriteLine("dekrüpt");
            }

            else {
                Console.WriteLine("Sellist valikut ei ole");
            }
        }
    }
}
