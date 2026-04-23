using System;
using System.Linq;

class Program
{
    static void Main(String[] args)
    {
        ForLoopExample();
        Console.WriteLine("______________________________________");
        ForEachLoopExample();
        Console.WriteLine("______________________________________");
        LinkqQueryOverInts();
        Console.WriteLine("______________________________________");
        WhileLoopEaxample();
        Console.WriteLine("______________________________________");
        DoWhileLoopExample();
        Console.WriteLine("______________________________________");
        TernarOperation();
        Console.WriteLine("______________________________________");
        SwitchExample();
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

    static void WhileLoopEaxample()
    {
        Console.WriteLine("While Loop Example");
        string userIsDone = "";
        while(userIsDone.ToLower() != "yes")
        {
            Console.WriteLine("In while loop");
            Console.Write("Are you done? [yes] [no] :");
            userIsDone = Console.ReadLine();
        }
    }

    static void DoWhileLoopExample()
    {
        Console.WriteLine("Do While Loop Example");
        string userIsDone = "";
        do
        {
            Console.WriteLine("In while loop");
            Console.Write("Are you done? [yes] [no] :");
            userIsDone = Console.ReadLine();
        } while (userIsDone.ToLower() != "yes");
    }

    static void TernarOperation()
    {
        string stringData = "My text data";
        int i = stringData.Length;
        Console.WriteLine(i > 0
            ? "string is greater than 0 characters" : "string is greater than not 0 characters");
        Console.WriteLine();
    }

    static void SwitchExample()
    {
        Console.WriteLine("1 [c#], 2 [VB]");
        Console.WriteLine("Please pick your language preference:");
        string langChoice = Console.ReadLine();
        int n = int.Parse(langChoice);
        switch (n)
        {
            case 1:
                Console.WriteLine("Good choice c#. C# is a fine language");
                break;
            case 2:
                Console.WriteLine("Good choice VB. VB is a fine language");
                break;
            default:
                Console.WriteLine("Well. Good luck");
                break;
        }
    }
}