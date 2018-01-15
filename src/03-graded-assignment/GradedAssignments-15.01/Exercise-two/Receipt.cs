using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_two
{
    public class Receipt
    {
        private string restaurantName;
        private string restaurantAddress;

        private Tab newTab;

        public Receipt(string n, string a, Tab t)
        {
            this.restaurantName = n;
            this.restaurantAddress = a;
            this.newTab = t;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.restaurantName);
            sb.AppendLine(this.restaurantAddress);
            sb.AppendLine("-------------------------");

            foreach (double item in this.newTab.Items)
            {
                sb.AppendLine($"Item: {item}");
            }

            double itemsTotal = this.newTab.Items.Sum();

            sb.AppendLine("-------------------------");
            sb.AppendLine($"Subtotal : €{Math.Round(itemsTotal, 2)}");
            sb.AppendLine($"15% Gratuity: {Math.Round(itemsTotal * 0.15, 2)}");
            sb.AppendLine($"Total: {Math.Round(itemsTotal - itemsTotal * 0.15, 2)}");

            return sb.ToString();
        }

    }
}
