using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] array = new string[] { "24.02.1940 07:29:27", "20.09.1992 07:36:06", "05.03.1983 04:12:12", "03.04.1999 09:27:24", "07.07.2010 17:02:55", "02.08.1997 12:49:16",
                                            "18.12.2007 02:35:11", "06.04.2000 02:42:15", "21.01.1976 04:51:59", "21.01.1984 10:20:57", "21.09.1982 17:43:59", "12.10.1973 20:18:15",
                                            "22.07.2000 21:44:09", "25.11.1981 22:35:59", "25.05.1981 01:11:46", "19.07.1999 14:49:50", "18.12.1994 04:02:55", "23.04.2008 09:32:20",
                                            "09.06.1984 11:11:29", "05.04.1976 16:28:20", "19.01.1980 14:14:51", "22.06.2001 20:23:49", "25.11.1998 21:03:19", "26.11.1982 10:46:46",
                                            "08.02.1993 02:27:30", "14.10.2003 05:57:02", "01.04.1986 21:45:29", "22.06.2001 11:53:08", "09.03.2002 19:26:38", "08.10.1993 19:06:06"};
            int[] ages = new int[array.Length];
            int[] months = new int[array.Length];

            DateTime now = DateTime.Now;


            for (int i = 0; i < array.Length; i++)
            {
                var born = DateTime.Parse(array[i]);
                int age = DateTime.Now.Year - born.Year;
                if (DateTime.Now.Month < born.Month || (DateTime.Now.Month == born.Month && DateTime.Now.Day < born.Day))
                {
                    age--;
                }
                ages[i] = age;

                months[i] = born.Month;
            }

            int maxAge = ages.Max();
            Console.WriteLine("Maksimaalne vanus: " + maxAge);

            int averageAge = ages.Sum() / ages.Length;
            Console.WriteLine("Keskmine vanus aastates: " + averageAge);

            int minAge = ages.Min();
            Console.WriteLine("Minimaalne vanus: " + minAge);

            var monthList = new List<int>();
            var amountList = new List<int>();
            var groups = months.GroupBy(v => v);
            foreach (var group in groups)
            {
                monthList.Add(group.Key);
                amountList.Add(group.Count());
            }

            int maxAmount = amountList.Max();
            int maxIndex = amountList.ToList().IndexOf(maxAmount);
            int maxMonth = monthList[maxIndex];

            string monthStr = "";

            if(maxMonth == 1)
            {
                monthStr = "jaanuaris";
            }

            if (maxMonth == 2)
            {
                monthStr = "veebruaris";
            }

            if (maxMonth == 3)
            {
                monthStr = "märtsis";
            }

            if (maxMonth == 4)
            {
                monthStr = "aprillis";
            }

            if (maxMonth == 5)
            {
                monthStr = "mais";
            }

            if (maxMonth == 6)
            {
                monthStr = "juunis";
            }

            if (maxMonth == 7)
            {
                monthStr = "juulis";
            }

            if (maxMonth == 8)
            {
                monthStr = "augustis";
            }

            if (maxMonth == 9)
            {
                monthStr = "septembris";
            }

            if (maxMonth == 10)
            {
                monthStr = "oktoobris";
            }

            if (maxMonth == 11)
            {
                monthStr = "novembris";
            }

            if (maxMonth == 12)
            {
                monthStr = "detsembris";
            }

            Console.WriteLine($"Kõige rohkem on sünnipäevi {monthStr}");

            DateTime[] dates = new DateTime[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                dates[i] = DateTime.Parse(array[i]);
            }

            Array.Sort(dates);

            Console.WriteLine();

            Console.WriteLine("Timestampid kasvavalt");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(dates[i]);
            }

            Console.ReadLine();

        }
    }
}
