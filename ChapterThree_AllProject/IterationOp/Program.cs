using System;

class Program
{
    static void Main(String[] args)
    {
        ForLoopExample();
        ForEachLoopExample();
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
}