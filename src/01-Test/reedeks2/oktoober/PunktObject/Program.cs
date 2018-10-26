using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punktid3
{
    class Punkt
    {
        private int x;
        private int y;
        public Punkt(int ux, int uy)
        {
            x = ux; y = uy;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public double KaugusNullist()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
    class Punktiproov
    {
        public static void Main(string[] arg)
        {
            Punkt p1 = new Punkt(3, 4);
            Console.WriteLine(p1.GetX());
            Console.WriteLine(p1.GetY());
            Console.WriteLine(p1.KaugusNullist());
            Console.WriteLine();
            Punkt p2 = new Punkt(5, 8);
            Console.WriteLine(p2.GetX());
            Console.WriteLine(p2.GetY());
            Console.WriteLine(p2.KaugusNullist());
            Console.ReadKey();
        }
    }
}