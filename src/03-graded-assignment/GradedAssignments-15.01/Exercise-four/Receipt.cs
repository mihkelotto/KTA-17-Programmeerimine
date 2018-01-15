using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_four
{
    public class Receipt
    {
        private string _name;
        private string _address;

        private Tab _tab;

        public Receipt(string restaurantName, string address)
        {
            this._name = restaurantName;
            this._address = address;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this._name);
            sb.AppendLine(this._address);
            sb.AppendLine("-------------------------");

            foreach (double item in _tab.Entries)
            {
                sb.AppendLine($"Price of food item: {item}");
            }

            double itemsTotal = this._tab.Entries.Sum();

            sb.AppendLine("-------------------------");
            sb.AppendLine($"Subtotal : €{Math.Round(itemsTotal, 2)}");
            sb.AppendLine($"15% Gratuity: {Math.Round(itemsTotal * 0.15, 2)}");
            sb.AppendLine($"Total: {Math.Round(itemsTotal - itemsTotal * 0.15, 2)}");

            return sb.ToString();

        }

    }
}