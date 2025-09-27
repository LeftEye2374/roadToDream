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

static void ObjectFunctionality()
{
    Console.WriteLine("=> Syste.Object functionality");
    Console.WriteLine("12.GetHashCode = {0}", 12.GetHashCode);
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() ={0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}

static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data type functionality");
    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.Positivelnfinity: {0}",
    double.Positivelnfinity);
    Console.WriteLine("double.NegativeInfinity: {0}",
    double.Negativelnfinity);
    Console.WriteLine();
}