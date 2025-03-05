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

        public void addProduct(Product product)
        {
            if (product.Amount > 0)
            {
                _products.Add(product);
            }
        }

        public void removeProduct(Product product)
        {
            if (product.Amount > 0)
            {
                _products.Remove(product);
            }
        }

        public void getAllProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product + "\n");
            }
        }
    }
}
