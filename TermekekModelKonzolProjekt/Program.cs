using TermekekModelKonzolProjekt.Models;
using TermekekModelKonzolProjekt.Repos;

ProductRepo repo = new ProductRepo();

List<Product> products = new List<Product>
{
    new Product("Tej", "Élelmiszer"),
    new Product("Kenyér", "Élelmiszer"),
    new Product("Vaj", "Élelmiszer"),
    new Product("Sajt", "Élelmiszer"),
    new Product("Alma", "Gyümölcs"),
    new Product("Banán", "Gyümölcs"),
    new Product("Kávé", "Ital"),
    new Product("Tea", "Ital"),
    new Product("Cukor", "Fűszer"),
    new Product("Só", "Fűszer")
};

Random rand = new Random();
foreach (var product in products)
{
    product.SetPrice(rand.Next(100, 1000));
    product.SetAmount(rand.Next(1, 20));
    repo.AddProduct(product);
}

Console.WriteLine("Termékek a raktárban:");
repo.ListProducts();