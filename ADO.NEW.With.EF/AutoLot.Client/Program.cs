using AutoLot.Dal.DataOperations;
using AutoLot.Dal.Models;
using System.Collections.Generic;

InventoryDal dal = new InventoryDal();
List<CarViewModel> list = dal.GetAllInventory();
Console.WriteLine(" ************** All Cars **************");
Console.WriteLine("Id\tMake\tColor\tPet Name");
foreach (var itm in list)
{
    Console.WriteLine($"{itm.Id}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
}
Console.WriteLine();
CarViewModel car = dal.GetCar(list.OrderBy(x => x.Color).Select(x => x.Id).First());
Console.WriteLine("First Car By Color");
 Console.WriteLine("CarId\tMake\tColor\tPet Name");
 Console.WriteLine($"{car.Id}\t{car.Make}\t{car.Color}\t{car.PetName}");
try
{
    dal.DeleteCar(5);
    Console.WriteLine("Car deleted."); 
}
catch (Exception ex)
{
    Console.WriteLine($"An exception occured: {ex.Message}");
}
dal.InsertAuto(new Car { Color = "Blue", MakeId = 5, PetName = "TomMonster" });
list = dal.GetAllInventory();
var newCar = list.First(x => x.PetName == "TomMonster");
Console.WriteLine("************** New Car **************");
Console.WriteLine("CarId\tMake\tColor\tPet Name");
Console.WriteLine($"{newCar.Id}\t{newCar.Make}\t{newCar.Color}\t{newCar.PetName}");
dal.DeleteCar(newCar.Id);
Console.ReadLine();



