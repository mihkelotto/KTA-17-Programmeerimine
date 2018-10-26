using System;
namespace massiiv
{
    class Punkt
    {
        static int loendur = 0;
        private int nr;
        private int x;
        private int y;
        public Punkt(int ux, int uy)
        {
            x = ux; y = uy;
            nr = ++loendur;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public int GetNr()
        {
            return nr;
        }
    }
    class Punktiproov
    {
        public static void Main(string[] arg)
        {
            Punkt[] pd = new Punkt[10];
            for (int i = 0; i < pd.Length; i++)
            {
                pd[i] = new Punkt(i, i * i);
            }
            Console.WriteLine(pd[4].GetY());
        }
    }
}