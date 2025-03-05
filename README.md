**classroomos leírás**

Feladat:
Készítsen egy egyszerű C# alkalmazást, amely egy raktárban tárolt termékeket kezel. A
feladat során két osztályt kell létrehoznia: egy modell osztályt (Product) és egy adatkezelő
osztályt (ProductRepo). Az osztályoknak az alábbi követelményeknek kell megfelelniük:
1. Product osztály
 A terméknek rendelkeznie kell az alábbi tulajdonságokkal:
o Név (string, nem lehet üres)
o Ár (decimal, nem lehet negatív)
o Mennyiség (int, nem lehet negatív)
o Kategória (string, nem lehet üres)
 A termék neve és kategóriája kötelező paraméterként legyen megadva a
konstruktorban.
 Az ár és a mennyiség módosítható legyen külön metódusokkal, amelyek hibát
dobjanak, ha negatív értéket próbálnak beállítani.
 Készítsen egy ToString() metódust, amely a termék összes adatát kiírja egy jól
olvasható formában.
2. ProductRepo osztály
 Egy privát listában tárolja a termékeket.
 Készítsen egy metódust, amely egy új terméket ad a listához, de csak akkor, ha annak
mennyisége nagyobb, mint 0.
 Készítsen egy metódust, amely töröl egy terméket, de csak akkor, ha annak
mennyisége 0.
 Készítsen egy metódust, amely kilistázza az összes terméket.
3. Az elkészített model és repo osztályokat tesztelje a következő kóddal:
ProductRepo repo = new ProductRepo();

List&lt;Product&gt; products = new List&lt;Product&gt;
{
new Product(&quot;Tej&quot;, &quot;Élelmiszer&quot;),
new Product(&quot;Kenyér&quot;, &quot;Élelmiszer&quot;),
new Product(&quot;Vaj&quot;, &quot;Élelmiszer&quot;),
new Product(&quot;Sajt&quot;, &quot;Élelmiszer&quot;),
new Product(&quot;Alma&quot;, &quot;Gyümölcs&quot;),
new Product(&quot;Banán&quot;, &quot;Gyümölcs&quot;),
new Product(&quot;Kávé&quot;, &quot;Ital&quot;),
new Product(&quot;Tea&quot;, &quot;Ital&quot;),

new Product(&quot;Cukor&quot;, &quot;Fűszer&quot;),
new Product(&quot;Só&quot;, &quot;Fűszer&quot;)
};

Random rand = new Random();
foreach (var product in products)
{
product.SetPrice(rand.Next(100, 1000));
product.SetQuantity(rand.Next(1, 20));
repo.AddProduct(product);
}

Console.WriteLine(&quot;Termékek a raktárban:&quot;);
repo.ListProducts();

Beküldési követelmények:
 A programot fordítható és futtatható állapotban kell leadni.
 Az osztályokat megfelelő névvel és szerkezettel kell elkészíteni.
 A kód legyen jól formázott és olvasható.
 A bin és obj mappákat ne töltse fel, csak a forráskódokat
Jó munkát!
