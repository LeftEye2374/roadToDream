using System;

Console.WriteLine("My first c# app");
Console.WriteLine("Hello world");
Console.WriteLine();

foreach(String arg in args)
{
    Console.WriteLine("Arg: {0}", arg);
}

Console.ReadLine();
return 0;
