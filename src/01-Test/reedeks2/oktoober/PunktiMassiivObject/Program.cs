using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiiv6ige
{
    public class KorTab
    {
        private int[,] kt; // = new int[sz, sz];
        private int sz; // array suurus

        public KorTab(int usz)
        {
            sz = usz;
            kt = new int[sz, sz];
            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < sz; j++)
                {
                    kt[i, j] = i * j;
                }
            }
        }
        public int GetKor(int i, int j)
        {
            return kt[i, j];
        }
        public int GetSz()
        {
            return sz;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KorTab kt = new KorTab(12);
            int mysize = kt.GetSz();

            for (int i = 0; i < mysize; i++)
            {
                for (int j = 0; j < mysize; j++)
                {
                    Console.Write(kt.GetKor(i, j) + " ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
