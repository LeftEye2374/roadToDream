using System;
using FunWithLinqExpressions;

Console.WriteLine("Fun with Query Expressions");
ProductInfo[] itemInStock = new[]
{
    new ProductInfo{Name = "Mac", Description = "Coffee", NumberInStock = 24},
    new ProductInfo{Name = "Macbook", Description = "Laptop", NumberInStock = 31},
    new ProductInfo{Name = "Milk", Description = "white water", NumberInStock = 23},
    new ProductInfo{Name = "cake", Description = "blue cake", NumberInStock = 12},
    new ProductInfo{Name = "pizza", Description = "pizza", NumberInStock = 11},
};
GetNameAndDescription(itemInStock);
Console.ReadLine();

static void SelectEvrething(ProductInfo[] products)
{
    Console.WriteLine("All product details");
    var allProduct = from product in products select product;
    foreach (var product in allProduct)
    {
        Console.WriteLine(product.ToString());
    }
}

static void SelectPorductNames(ProductInfo[] products)
{
    Console.WriteLine("All product Names");
    var allProductNames = from p in products select p.Name;
    foreach (var product in allProductNames)
    {
        Console.WriteLine(product);
    }
}

static void MediumLvlQuery(ProductInfo[] products)
{
    Console.WriteLine("Medium level query");
    var query = from p in products where p.NumberInStock > 15 select p.Name;
    foreach (var product in query)
    {
        Console.WriteLine(product);
    }
}

static void GetNameAndDescription(ProductInfo[] products)
{
    Console.WriteLine("Name and Description");
    var nameAndDescription = from p in products select (p.Name, p.Description);
    foreach (var nd in  nameAndDescription )
    {
        Console.WriteLine(nd);
    }
}