using System;
using SimpleGS;

Console.WriteLine("GS basic");
Car refToMyCar = new Car("Zippy",50);
Console.WriteLine(refToMyCar.ToString());
Console.ReadLine();


static void MakeACar()
{
    Car myCar = new Car();
    myCar = null;
}