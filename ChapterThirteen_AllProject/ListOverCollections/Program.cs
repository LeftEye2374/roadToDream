using System;
using ListOverCollections;

Console.WriteLine("LINQ over Generics Collection");
List<Car> myCar = new List<Car>()
{
    new Car {PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
    new Car {PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
    new Car {PetName = "Mary", Color = "Black", Speed = 55, Make = "VM"},
    new Car {PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
    new Car {PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
};
Console.ReadLine();

