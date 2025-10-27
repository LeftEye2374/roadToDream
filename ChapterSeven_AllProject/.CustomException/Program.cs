using System;
using CustomException;

Console.WriteLine("Fun with Custom Exception");
Car myCar = new Car();
try
{
    myCar.Accelerate(50);



}
catch (CarIsDeadException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.CauseOfException);
    Console.WriteLine(ex.CauseOfException);
}
Console.ReadLine();