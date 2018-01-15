using System;

namespace Exercise_four
{
    public class Restaurant
    {
        private string _name;
        private string _address;

        public Restaurant(string restaurantName, string address)
        {
            this._name = restaurantName;
            this._address = address;
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(_name, _address);
        }
    }
}