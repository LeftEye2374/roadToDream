using System

Console.WriteLine("Fun with type convers");
short num1 = 9;
short num2 = 10;
Console.WriteLine("{0} + {1} = {2}", num1, num2, Add(num1, num2));
Console.ReadLine();

static int Add(short num1, short num2)
{
    return num1 + num2;
}