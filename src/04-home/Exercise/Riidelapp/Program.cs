using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riidelapp
{
    class Riidelapp
    {
        private int pikkus;
        private int laius;
        private int toon;


        public Riidelapp(int pikkus2, int laius2, int toon2)
        {
            pikkus = pikkus2;
            laius = laius2;
            toon = toon2;
        }

        public int GetPikkus()
        {
            return pikkus;
        }
        public int GetLaius()
        {
            return pikkus;
        }

        public int GetToon()
        {
            return toon;
        }



        public int Poolita()
        {
            pikkus = pikkus / 2;
            return pikkus;
        }
        class Proov
        {
            static void Main(string[] args)
            {

            }
        }


    }
}
