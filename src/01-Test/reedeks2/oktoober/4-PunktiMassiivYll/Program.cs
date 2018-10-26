using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiiv2
{

    class Lappid
    {

        private int pikkus;
        private int laius;
        private int toon;
        public Lappid(int upikkus, int ulaius, int utoon)
        {
            pikkus = upikkus;
            laius = ulaius;
            toon = utoon;
        }
        public int GetPikkus()
        {
            return pikkus;
        }
        public int GetLaius()
        {
            return laius;
        }
        public int GetToon()
        {
            return toon;
        }

        public int Pindala()
        {
            return pikkus * laius;
        }

        static void Main(string[] args)
        {
           /* Lappid[] lappid = new Lappid[10];
            for (int i = 0; i < lappid.Length; i++)
            {
                lappid[i] = new Lappid(i + 5, i * 2, (0xff << i) & 0xffffff);
                Console.WriteLine(lappid[i].GetPikkus() + " " + lappid[i].GetLaius() + " " + lappid[i].GetToon());
            }

            Console.WriteLine(); 



            Lappid[] lappid2 = new Lappid[10];
            for (int i = 0; i < lappid2.Length / 2; i++)
            {
                lappid2[i] = lappid[i];
            }
            for (int i = 5; i < lappid2.Length; i++)
            {
                lappid2[i] = new Lappid(i + 7, i * 9, (0xff >> i) & 0xffffff); // biti kaupa 00000111  <<1   00001110  <<1 00011100  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
            }

            for (int i = 0; i < lappid.Length; i++)
            {
                Console.WriteLine(lappid2[i].GetPikkus() + " " + lappid2[i].GetLaius() + " " + lappid2[i].GetToon());
            }

            int summa1 = 0;
            for (int i = 0; i < lappid.Length; i++)
            {
                summa1 = lappid2[i].Pindala();
                summa1++;
            }

            int summa2 = 0;
            for (int i = 0; i < lappid.Length; i++)
            {
                summa2 = lappid2[i].Pindala();
                summa2++;
            }

            int pindaladeSumma = summa1 + summa2;
            Console.WriteLine(pindaladeSumma);

            */

            const int sz = 11;
            Random r = new Random();
            int[,] kt = new int[sz, sz];
            int[,] rt = new int[sz, sz];

            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < sz; j++)
                {
                    kt[i, j] = i * j;
                    //rt[i, j] = r.Next(); &0xff
                }
            }

            Console.ReadKey();
        }
    }
}