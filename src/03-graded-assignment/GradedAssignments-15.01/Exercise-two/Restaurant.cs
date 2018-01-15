using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_two
{
    public class Restaurant
    {
        private readonly string _name;

        private readonly string _address;

        public Restaurant(string name, string address)
        {
            this._name = name;
            this._address = address;
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(this._name, this._address, tab);
        }
    }
}
