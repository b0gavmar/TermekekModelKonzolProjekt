using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermekekModelKonzolProjekt.Models;

namespace TermekekModelKonzolProjekt.Repos
{
    public class ProductRepo
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product.Amount > 0)
            {
                _products.Add(product);
            }
        }

        public void RemoveProduct(Product product)
        {
            if (product.Amount == 0)
            {
                _products.Remove(product);
            }
        }

        public void ListProducts()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("Nincs termék a raktárban.");
                return;
            }

            foreach (Product product in _products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
