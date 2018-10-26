using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_test
{
    class Ristkylik
    {
        private int pikkus;
        private int laius;

        public Ristkylik(int upikkus, int ulaius)
        {
            pikkus = upikkus;
            laius = ulaius;
        }
        public int GetPikkus()
        {
            return pikkus;
        }
        public int GetLaius()
        {
            return laius;
        }
        public int Pindala()
        {
            return pikkus * laius;
        }
        public Ristkylik PlusOne()
        {
            pikkus += 1;
            laius += 1;
            return new Ristkylik(pikkus, laius) ;
        }
        public Ristkylik PlusNumber(int n)
        {
            pikkus += n;
            laius += n;
            return new Ristkylik(pikkus, laius);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Ristkylik r1 = new Ristkylik(4, 8);
            Ristkylik r2 = new Ristkylik(5, 9);
            Ristkylik r3 = new Ristkylik(6, 10);
            Ristkylik r4 = new Ristkylik(7, 11);
            Console.WriteLine(r1.Pindala());
            Console.WriteLine(r2.Pindala());
            Console.WriteLine(r3.Pindala());
            Console.WriteLine(r4.Pindala());
            int pikkusteSumma = r1.GetPikkus() + r2.GetPikkus() + r3.GetPikkus() + r4.GetPikkus();
            Console.WriteLine(pikkusteSumma);
            r1.PlusOne();
            Console.WriteLine(r1.GetPikkus() + " , " + r1.GetLaius());
            r2.PlusNumber(2);
            Console.WriteLine(r2.GetPikkus() + " , " + r2.GetLaius());


            Console.ReadKey();
        }
    }
}
