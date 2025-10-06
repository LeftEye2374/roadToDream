using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Fun with Arrayes");
        Console.WriteLine("___________________________");
        SimpleArray();
        Console.WriteLine("___________________________");
        ArrayInit();
    }

    static void SimpleArray()
    {
        int[] myInts = new int[5];
        myInts[0] = 1;
        myInts[1] = 2;
        myInts[2] = 3;
        myInts[3] = 4;
        myInts[4] = 5;

        foreach (int i in myInts)
        {
            Console.WriteLine(i);
        }
    }

    static void ArrayInit()
    {
        string[] stringArray = new string[3] { "one", "two", "three" };
        Console.WriteLine("String array has length - {0}", stringArray.Length);
        int[] myInts =  new int[3] {3, 15, 45};
        foreach (int i in myInts)
        {
            Console.WriteLine(i);
        }
    }
}