using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yl4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 19881222, 19550330, 19761101, 19640814, 20090921, 20000305, 19430601, 19400919, 20051102, 20011010, 20011230 };
            int[] ages = new int[array.Length];
            int[] months = new int[array.Length];

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            for (int i = 0; i < array.Length; i++)
            {
                int age = (now - array[i]) / 10000;
                ages[i] = age;
            }

            int maxAge = ages.Max();
            Console.WriteLine("Maksimaalne vanus: " + maxAge);

            int sumAge = ages.Sum();
            Console.WriteLine("Keskmine vanus: " + (sumAge / ages.Length));

            int minAge = ages.Min();
            Console.WriteLine("Minimaalne vanus: " + minAge);

            for (int i = 0; i < array.Length; i++)
            {
                int month = (array[i] / 100) % 100;
                months[i] = month;
            }

            var groups = months.GroupBy(v => v);
            foreach (var group in groups)
            Console.WriteLine("Value {0} has {1} items", group.Key, group.Count());

            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Timestampid kasvavalt");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
