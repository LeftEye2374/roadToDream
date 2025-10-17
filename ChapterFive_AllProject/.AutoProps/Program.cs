using System;
using AutoProps;

Console.WriteLine("Fun with Auto incapsulation");
Car c = new Car();
c.PetName = "Frank";
c.Speed = 55;
c.Color = "red";
Console.WriteLine("Your car has name - {0}", c.PetName);
c.DisplayStats();
Console.ReadLine();
