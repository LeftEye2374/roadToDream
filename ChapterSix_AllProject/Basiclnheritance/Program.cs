using System;
using Basiclnheritance;

Console.WriteLine("Basic Inheritance");
Car myCar = new Car(80) { Speed = 50 };

Console.WriteLine("My car is going - {0} MPH", myCar.Speed);
Console.ReadLine();

Console.WriteLine("____________________________________");

MiniVan miniVan = new MiniVan();
miniVan.Speed = 10;
Console.WriteLine("My minivan is going - {0} MPH", miniVan.Speed);
// Ошибка 
miniVan._currSpeed = 50;
Console.ReadLine();