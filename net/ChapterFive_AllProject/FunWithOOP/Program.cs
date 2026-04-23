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
        Console.WriteLine("_____________");
        Book setBook = new Book(123);
        Console.WriteLine(setBook.GetNumberOfPages());
        setBook.SetNumberOfPages(543);
        Console.WriteLine(setBook.GetNumberOfPages());
        Console.ReadLine();
    }
}