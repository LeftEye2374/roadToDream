using System;

DisplayBaseClass<int>();
DisplayBaseClass<string>();
Console.ReadLine();



static void DisplayBaseClass<T>()
{
    Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
}