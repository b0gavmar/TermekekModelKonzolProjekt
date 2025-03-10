﻿using System;
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
            return _products
                    .Where(product => product.Price >= Math.Min(start, end) && product.Price <= Math.Max(start, end))
                    .ToList();
        }



        public List<string> GetAllCategories()
        {
            return _products.Select(product => product.Category).Distinct().ToList();
        }



        public Dictionary<string, int> GroupNumberOfProductsByCategories()
        {
            return _products
                .GroupBy(product => product.Category)
                .ToDictionary(category => category.Key, products => products.Count());
        }
        public Dictionary<string, List<Product>> GroupAllProductsByPrice()
        {
            return _products
                .GroupBy(product => product.Price > 500 ? "500 Ft feletti" : "500 Ft alatti")
                .ToDictionary(category => category.Key, products => products.ToList());
        }
    }
}
