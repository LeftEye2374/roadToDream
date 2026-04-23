using AutoLot.Samples;
using AutoLot.Samples.Models;

Console.WriteLine("hello");
Car myCar = new Car()
{
    Color = "Yellow",
    MakeId = 1,
    PetName = "Jm"
};
ApplicationDbContext.Cars.Add(myCar);
