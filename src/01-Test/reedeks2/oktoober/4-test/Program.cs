using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 10;
            int loendur = 0;
            int[,] matrix = new int[s,s];

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    matrix[i, j] = loendur + 1;
                    loendur++;
                }
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    if (matrix[i, j] < 10)
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
