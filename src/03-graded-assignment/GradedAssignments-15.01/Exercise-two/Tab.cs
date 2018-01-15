using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_two
{
    public class Tab
    {
        public List<double> Items { get; private set; } = new List<double>();

        public void Add(double value)
        {
            Items.Add(value);
        }
    }

}
