using System;

namespace ConsoleCSharpConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My console app";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome to my console app");
            Console.WriteLine("****************************************************");
            Console.ReadLine();
        }
    }
}
