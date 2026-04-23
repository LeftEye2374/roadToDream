using System;
using PublicDelegateProblem;

Console.WriteLine("Fun With No Encapsulation");
Car myCar = new Car();
myCar.ListOfHandlers = CallWithExploded;
myCar.Accelerate(10);
myCar.ListOfHandlers = CallHereToo;
myCar.Accelerate(10);
myCar.ListOfHandlers.Invoke("Hee, hee, hee");

Console.ReadLine();

static void CallWithExploded(string msg)
{
    Console.WriteLine(msg);
}

static void CallHereToo(string msg)
{
    Console.WriteLine(msg);
}

