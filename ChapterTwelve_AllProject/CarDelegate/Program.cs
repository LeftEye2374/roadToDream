using System;
using CarDelegate;

Console.WriteLine("Delegate as event enablers");

Car c1 = new Car("SlugBag", 100, 10);
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
Console.WriteLine("Speeding up");
for(int i =0; i < 6; i++)
{
    c1.Accelerate(20);
}
Console.ReadLine();


static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("Message From Car  Object");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("*********************************");
}