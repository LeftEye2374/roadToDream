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
GetFastCars(myCar);
Console.ReadLine();

static void GetFastCars(List<Car> myCars)
{
    var fastCars = from c in myCars where c.Speed > 55 select c;
    foreach (var car in fastCars )
    {
        Console.WriteLine("{0} is going too fast!", car.PetName);
    }
}