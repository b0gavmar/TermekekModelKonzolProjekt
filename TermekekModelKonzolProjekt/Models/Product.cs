using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermekekModelKonzolProjekt.Models
{
    public class Product
    {
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Category { get; set; }

        public Product(string name,string category)
        {
            Name = name;
            Category = category;
        }

        public void SetPrice(decimal price)
        {
            if (price < 0) throw new ArgumentException("Az ár nem lehet negatív!");
            Price = price;
        }

        public void SetAmount(int amount)
        {
            if (amount < 0) throw new ArgumentException("Az mennyiség nem lehet negatív!");
            Amount = amount;
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
