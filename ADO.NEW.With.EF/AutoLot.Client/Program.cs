using System;
using System.Linq;
using AutoLot.Dal;
using AutoLot.Dal.Models;
using AutoLot.Dal.DataOperations;
using System.Collections.Generic;

InventoryDal dal = new InventoryDal();
List<CarViewModel> list = dal.GetAllInventory();
Console.WriteLine("All Cars");
Console.WriteLine("Id\tMake\tColor\tPet Name");
foreach (var itm in list)
{
    Console.WriteLine("Id\tMake\tColor\tPet Name");
}
Console.WriteLine();
CarViewModel car = dal.GetCar(list.OrderBy(x => x.Color).Select(x => x.Id).First());
Console.WriteLine("Frist Car By Color:");
Console.WriteLine("Id\tMake\tColor\tPet Name");
try
{
    dal.DeleteCar(5);
    Console.WriteLine("Car was deleted");
}
catch (Exception ex)
{
    Console.WriteLine($"An Exception occured: {ex.Message}");
}
dal.InsertAuto(new Car {Color ="Blue", MakeId = 5, PetName = "TomMonster"});
list = dal.GetAllInventory();
var newCar = list.First(x => x.PetName == "TomMonster");
Console.WriteLine("New Car");
Console.WriteLine("Id\tMake\tColor\tPet Name");
Console.WriteLine($"{newCar.Id}\t{newCar.Make}\t{newCar.Color}\t{newCar.PetName}");
dal.DeleteCar(newCar.Id);
Console.ReadLine();
