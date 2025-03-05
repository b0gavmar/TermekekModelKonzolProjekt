using System;
using System.Collections.Generic;
using System.Diagnostics;
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



        public int GetNumberOfProducts()
        {
            return _products.Count;
        }
        public int GetNumberOfProductsOfCategory(string category)
        {
            return _products.Where(product => product.Category==category).Count();
        }
        public int GetNumberOfProductsOfHigherPrice(int price)
        {
            return _products.Where(product => product.Price > price).Count();
        }



        public List<Product> GetProductsOfHigherPrice(int price)
        {
            return _products.Where(product => product.Price > price).ToList();
        }
        public List<Product> GetProductsWithLesserAmount(int amount)
        {
            return _products.Where(product => product.Amount <amount).ToList();
        }
        public List<Product> GetProductsOfCategory(string category)
        {
            return _products.Where(product => product.Category == category).ToList();
        }
        public List<Product> GetProductsStartingWith(string nameStart)
        {
            return _products.Where(product => product.Name.StartsWith(nameStart)).ToList();
        }
        public List<Product> GetProductsWithPriceBetweenAmounts(int start, int end)
        {
            if(start < end)
            {
                return _products.Where(product => start < product.Price && product.Price > end).ToList();
            }
            else
            {
                return _products.Where(product => end < product.Price && product.Price > start).ToList();
            }
        }



        public List<string> GetAllCategories()
        {
            return _products.Select(product => product.Category).Distinct().ToList();
        }
    }
}
