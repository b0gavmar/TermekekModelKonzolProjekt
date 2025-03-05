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


// eredeti feladat folytatása
Console.WriteLine($"Összes termék száma: {repo.GetNumberOfProducts()}");
Console.WriteLine($"Élelmiszer kategóriájú termékek száma: {repo.GetNumberOfProductsOfCategory("Élelmiszer")}");
Console.WriteLine($"500 Ft-nál drágább termékek száma: {repo.GetNumberOfProductsOfHigherPrice(500)}");


Console.WriteLine("\n500 Ft alatti termékek:");
foreach (var product in repo.GetProductsWithPriceBetweenAmounts(0, 500))
{
    Console.WriteLine($"- {product.Name} ({product.Price} Ft)");
}

Console.WriteLine("\n5-nél kevesebb darabos termékek:");
foreach (var product in repo.GetProductsWithLesserAmount(5))
{
    Console.WriteLine($"- {product.Name} ({product.Amount} db)");
}

Console.WriteLine("\nK betűvel kezdődő termékek:");
foreach (var product in repo.GetProductsStartingWith("K"))
{
    Console.WriteLine($"- {product.Name}");
}

Console.WriteLine("\nTermékek, amelyek ára 300 és 700 Ft között van:");
foreach (var product in repo.GetProductsWithPriceBetweenAmounts(300, 700))
{
    Console.WriteLine($"- {product.Name} ({product.Price} Ft)");
}


Console.WriteLine("\nEgyedi kategóriák a raktárban:");
foreach (var category in repo.GetAllCategories())
{
    Console.WriteLine($"- {category}");
}

Console.WriteLine("\nTermékek száma kategóriánként:");
var categoryCounts = repo.GroupNumberOfProductsByCategories();
foreach (var category in categoryCounts)
{
    Console.WriteLine($"{category.Key}: {category.Value} db");
}

Console.WriteLine("\nTermékek csoportosítása ár szerint:");
var groupedByPrice = repo.GroupAllProductsByPrice();
foreach (var group in groupedByPrice)
{
    Console.WriteLine($"\n{group.Key}:");
    foreach (var product in group.Value)
    {
        Console.WriteLine($"  - {product.Name} ({product.Price} Ft)");
    }
}