using System;
using Basiclnheritance;

Console.WriteLine("Basic Inheritance");
Car myCar = new Car(80) { Speed = 50 };

Console.WriteLine("My car is going - {0} MPH", myCar.Speed);
Console.ReadLine();
