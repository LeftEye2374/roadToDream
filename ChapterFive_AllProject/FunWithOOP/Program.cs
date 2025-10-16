using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fun with OOP");
        Book book = new Book();
        Console.WriteLine(book);
        Console.WriteLine("_____________");
        Book microBook = new Book(121);
        Console.WriteLine(microBook.numberOfPages);
    }
}