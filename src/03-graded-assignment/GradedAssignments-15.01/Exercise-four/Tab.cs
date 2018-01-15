using System;
using System.Collections.Generic;

namespace Exercise_four
{
    public class Tab
    {
        public List<double> Entries { get; private set; } = new List<double>();

        public void Add(double price)
        {
            Entries.Add(price);
        }
    }
}