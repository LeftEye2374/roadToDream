using System;
using System.Linq;
using AutoLot.Dal;
using AutoLot.Dal.Models;
using AutoLot.Dal.DataOperations;
using System.Collections.Generic;
using System.Drawing;

InventoryDal dal = new InventoryDal();
List<CarViewModel> list = dal.GetAllInventory();
Console.WriteLine("**************** All Cars ****************");
Console.WriteLine("Id\tMake\tColor\tPetName");
foreach (var itm in list)
{
    Console.WriteLine($"{itm.Id}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
}
Console.WriteLine();

CarViewModel car = dal.GetCar(list.OrderBy(x => x.Color).Select(x => x.Id).First());
Console.WriteLine("**************** First Car By Color ****************");
Console.WriteLine("Id\tMake\tColor\tPetName");
Console.WriteLine($"{car.Id}\t{car.Make}\t{car.Color}\t{car.PetName}");
try
{
    dal.DeleteCar(5);
    Console.WriteLine("Car was deleted");
}
catch (Exception ex)
{
    Console.WriteLine($"An exception occurre: {ex.Message}");
}
dal.InserAuto(new Car({ Color = "Blue", MakeId = 5, PetName = "Tom Monstr" });

list = dal.GetAllInventory();
var newCar = list.First(x => x.PetName == "Tom Monstr");
Console.WriteLine("**************** New Car ****************");
Console.WriteLine("Id\tMake\tColor\tPetName");
Console.WriteLine($"{newCar.Id}\t{newCar.Make}\t{newCar.Color}\t{newCar.PetName}");
dal.DeleteCar(newCar.Id);
Console.ReadLine()_;


