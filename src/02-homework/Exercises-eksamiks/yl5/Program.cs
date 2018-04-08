using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yl5
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = "suvaline tekst";
            System.IO.File.WriteAllText(@"C:\Users\mihke\Desktop\path.txt", contents);
        }
    }
}
