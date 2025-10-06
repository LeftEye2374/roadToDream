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
        Console.WriteLine("___________________________");
        DeclareImplicitArrays();
        Console.WriteLine("___________________________");
        ArraysOfObject();
        Console.WriteLine("___________________________");
        RectMultidimensionalArray();
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

    static void DeclareImplicitArrays()
    {
        Console.WriteLine("=> Implicit Array inicialization");
        var a = new[] { 1, 2, 3, 4 };
        Console.WriteLine("a is - {0}", a.ToString);
    }

    static void ArraysOfObject()
    {
        object[] myObjects = new object[4];
        myObjects[0] = 1;
        myObjects[1] = "string";
        myObjects[2] = 2.14;
        myObjects[3] = true;

        foreach(object o in myObjects)
        {
            Console.WriteLine(o);
        }
    }

    static void RectMultidimensionalArray()
    {
        Console.WriteLine("=> Rectangular multidimensional array");
        int[,] myMatrix;
        myMatrix = new int[3, 4];
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                myMatrix[i, j] = i * j;
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(myMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}