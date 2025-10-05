using System;
using System.Linq;

class Program
{
    static void Main(String[] args)
    {
        ForLoopExample();
        ForEachLoopExample();
        LinkqQueryOverInts();
    }

    static void ForLoopExample()
    {
        for(int i =0; i < 5; i++)
        {
            Console.WriteLine("Aslan huisos");
        }
    }

    static void ForEachLoopExample()
    {
        string[] carTypes = {"BMW", "Mercedeas", "Audi", "Honda" };
        foreach (string carType in carTypes) {
            Console.WriteLine(carType);
        }
    }

    static void LinkqQueryOverInts()
    {
        int[] numbers = {10, 20, 30, 40 , 1, 4, 5, 8 };
        var subset = from i in numbers where i < 10 select i;
        Console.WriteLine("Values in subset: ");
        foreach (var i in subset)
        {
            Console.WriteLine("{0}", i);
        }
    }
}