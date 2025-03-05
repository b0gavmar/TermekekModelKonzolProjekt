using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermekekModelKonzolProjekt.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; private set; }
        public int Amount { get; private set; }
        public string Category { get; set; }

        public Product(string name, string category, decimal price = 0, int amount = 0)
        {
            Name = name;
            Category = category;
            SetPrice(price);
            SetAmount(amount);
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
            return  $"A termék neve: {Name}\n" +
                    $"\t- Ára: {Price}\n" +
                    $"\t- Mennyisége: {Amount}db\n" +
                    $"\t- Kategóriája: {Category}\n";
        }
    }
}
