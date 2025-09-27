using System;
using System.Numerics;
Console.WriteLine("Fun with Basic Data Types \n");


static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");
    int mylnt = 0;
    string myString;
    myString = "This is my character data";
    Console.WriteLine();
}

static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations");
    int myInt = default;
}

static void NewingDataType()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();
    int i = new int();
    double d = new double();
    DateTime dt = new DateTime();
    Console.WriteLine("{ 0},{ 1},{ 2},{ 3}", b, i, d, dt);
    Console.WriteLine();
}