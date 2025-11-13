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
Console.ReadLine();