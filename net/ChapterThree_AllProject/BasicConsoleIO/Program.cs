using System;

Console.WriteLine("Basic console IO");
GetUserData();
Console.ReadLine();

static void GetUserData()
{
    Console.WriteLine("Please write your name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Please write your age: ");
    string age = Console.ReadLine();

    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("Hello {0}! You are {1} years old.", name, age);
    Console.ForegroundColor = prevColor;
}