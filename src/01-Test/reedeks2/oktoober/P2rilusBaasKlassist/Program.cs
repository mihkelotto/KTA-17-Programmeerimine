using System;
namespace Parilus2
{
    class Inimene
    {
        protected int vanus;
        protected float pikkus;

        public Inimene(int uvanus, float upikkus)
        {
            vanus = uvanus;
            pikkus = upikkus;
        }
        public Inimene(int uvanus)
        {
            vanus = uvanus;
            pikkus = -1;

        }
        public void YtleVanus()
        {
            Console.WriteLine("Minu vanus on " + vanus + " aastat");
        }
        public void YtlePikkusvanus()
        {
            Console.WriteLine("Minu vanus on " + vanus + " Pikkus = " + pikkus);
        }
    }
    class Modell : Inimene
    {
        protected int ymberm66t;
        public Modell(int vanus, float pikkus, int uymberm66t) : base(vanus, pikkus)
        {
            ymberm66t = uymberm66t;
        }
        public Modell(int vanus, int uymberm66t) : base(vanus, -1)
        {
            ymberm66t = uymberm66t;
        }
        public void Esitle()
        {
            Console.WriteLine("Mu ymberm66duks on " + ymberm66t + " sentimeetrit");
            Console.WriteLine("Mu pikkus on " + pikkus + " sentimeetrit");
            YtleVanus();
        }
    }
    class InimTest
    {
        public static void Main(string[] arg)
        {
            //Modell m = new Modell(20, 162, 90);
            // m.Esitle();
            // Inimene a = new Modell(80, 111, 600);
            // a.YtleVanus();
            Inimene[] hulk = new Inimene[4];
            hulk[0] = new Modell(1, 2, 3);
            hulk[1] = new Inimene(10, 20);
            hulk[2] = new Modell(100, 200, 300);
            hulk[3] = new Inimene(1000);
            foreach (Inimene i in hulk)
            {
                i.YtlePikkusvanus();
            }
            Console.ReadKey();
        }
    }
}