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

static void CharFunctionality()
{
    Console.WriteLine("=> char type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}"f
   char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
    char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
    char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}",
    char.IsPunctuation('?'));
    Console.WriteLine(); 
}

static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}

static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        // Вывод значения b
        Console.WriteLine("Value of b: {0}", b);
    }
    else
    {
    }
    Console.WriteLine("Default value of b: {0}", b);
    // Вывод стандартного значения b
    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
    }
    Console.WriteLine("Value of d: {0}", d);
 else
    {
        // Преобразование входного значения в double потерпело неудачу
        // и переменной было присвоено стандартное значение.
        Console.WriteLine("Failed to convert the input ({0}) to a double
       
        and the variable was assigned the default { 1}
        ", value,d);
 }
    Console.WriteLine();
}