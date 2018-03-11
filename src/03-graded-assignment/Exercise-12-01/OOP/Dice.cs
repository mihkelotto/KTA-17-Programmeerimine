using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Dice
    {
        //public Random Random = new Random();
       // public int Sides;

        public int Roll(int sides)
        {
            var random = new Random();
            return random.Next(1, sides + 1);
        }

    }
}
