using System;
using SimpleDeligate;

Console.WriteLine("Simple Delegate Example");

//BinaryOp b = new BinaryOp(SimpleMath.Add);
//Console.WriteLine("10 + 10 = {0}", b(10,10));
//Console.WriteLine();
//DisplayDelegatelnfо(b);


static void DisplayDelegatelnfо(Delegate delObj)
{
    foreach(Delegate d in delObj.GetInvocationList())
    {
        Console.WriteLine("Method name: {0}", d.Method);
        Console.WriteLine("Type name: {0}", d.GetType);
    }
}
