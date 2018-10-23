using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riidelapp
{
    class Riidelapp
    {
        private double pikkus;
        private double laius;
        private string toon;


        public Riidelapp(double upikkus, double ulaius, string utoon)
        {
            pikkus = upikkus;
            laius = ulaius;
            toon = utoon;
        }

        public double GetPikkus()
        {
            return pikkus;
        }
        public double GetLaius()
        {
            return laius;
        }

        public string GetToon()
        {
            return toon;
        }



        public Riidelapp Poolita()
        {
            if(pikkus > laius || pikkus == laius)
            {
                pikkus = pikkus / 2;
            }

            else
            {
                laius = laius / 2;
            }

            return new Riidelapp(pikkus, laius, toon);
        }

        public Riidelapp PoolitaProtsent(double protsent)
        {
            if (pikkus > laius || pikkus == laius)
            {
                pikkus = pikkus * (protsent * 0.01);
            }

            else
            {
                laius = laius * (protsent * 0.01);
            }

            return new Riidelapp(pikkus, laius, toon);
        }

    }

    class RiidelappProov
    {
        static void Main(string[] args)
        {
            Riidelapp rl1 = new Riidelapp(6, 8, "valge");
            Console.WriteLine(rl1.GetPikkus());
            Console.WriteLine(rl1.GetLaius());
            Console.WriteLine(rl1.GetToon());
            Console.WriteLine();
            double pindala = rl1.GetPikkus() * rl1.GetLaius();
            Console.WriteLine("Pindala: " + pindala);
            Console.WriteLine();
            Riidelapp rl2 = rl1.Poolita();
            Console.WriteLine(rl2.GetPikkus());
            Console.WriteLine(rl2.GetLaius());
            Console.WriteLine(rl2.GetToon());
            Console.WriteLine();
            Riidelapp rl3 = new Riidelapp(14, 10, "must");
            double protsent = 25;
            Riidelapp rl4 = rl3.PoolitaProtsent(protsent);
            Console.WriteLine(rl4.GetPikkus());
            Console.WriteLine(rl4.GetLaius());
            Console.WriteLine(rl4.GetToon());
            Console.ReadKey();
            }
        }

}
