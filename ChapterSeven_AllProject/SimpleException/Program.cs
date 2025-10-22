using System;
using System.Collections;
using SimpleException;

Console.WriteLine("Simple Exception example");
Console.WriteLine("Creating a car and stepping on it!");
Car myCar =  new Car("Zippy", 20);
myCar.CruncTunes(true);

for (int i = 0; i < 10; i++)
{
    myCar.Accelerate(10);
}
Console.ReadLine();