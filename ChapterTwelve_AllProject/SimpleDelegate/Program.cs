using System;
using SimpleDeligate;

Console.WriteLine("Simple Delegate Example");
Console.WriteLine("x + y = {0}", SimpleMath.Add(10,15));
Console.ReadLine();

static void DisplayDelegatelnfо(Delegate delObj)
{
    foreach(Delegate d in delObj.GetInvocationList())
    {
        Console.WriteLine("Method name: {0}", d.Method);
        Console.WriteLine("Type name: {0}", d.GetType);
    }
}