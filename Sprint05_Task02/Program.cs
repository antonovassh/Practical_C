﻿//using System.Diagnostics;
//using System.Numerics;
//using System.Xml.Linq;

//You have the next Main realization: 

//        {
//    var products = new List<Product>();
//    products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
//    products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
//    products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
//    products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
//    products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
//    ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
//    TotalPrice(lookup);
//    Console.ReadKey();
//}
//Please create a method TotalPrice(ILookup<string, Product> lookup) in which print(Name + " " + Price) from one category and total price for products from these categories (Key + " " + totalPriceForCategory)

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }

    public static void TotalPrice(ILookup<string, Product> lookup)
    {
        foreach (var group in lookup)
        {
            decimal totalPriceForCategory = 0;

            foreach (var product in group)
            {
                Console.WriteLine($"{product.Name} {product.Price}");
                totalPriceForCategory += product.Price;
            }

            Console.WriteLine($"{group.Key} {totalPriceForCategory}");
        }
    }

}
