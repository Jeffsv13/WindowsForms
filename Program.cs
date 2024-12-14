using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Linq;

namespace FundamentosCSHARP
{
    static class Program
    {
        static void Main(string[] args)
        {

        }

        public class Drink
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public decimal Price { get; set; }
        }

        public class Invoice
        {
            public decimal GetTotal(IEnumerable<Drink> lstDrink)
            {
                decimal total = 0;
                foreach (var drink in lstDrink)
                {
                    if (drink.Type == "Agua")
                        total += drink.Price;
                    else if (drink.Type == "Azucar")
                        total += drink.Price * 0.333m;
                    else if (drink.Type == "Alcohol")
                        total += drink.Price * 0.16m;
                }
                return total;
            }
        }
    }
}