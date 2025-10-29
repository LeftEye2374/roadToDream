using System;
using System.IO;
using CustomException;

Console.WriteLine("Handing multiple Exception");
Car myCar = new Car("Rusty", 90);
try
{
    myCar.Accelerate(-10);
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();
