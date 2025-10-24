using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using SimpleException;

Console.WriteLine("Simple Exception example");
Console.WriteLine("Creating a car and stepping on it!");
Car myCar =  new Car("Zippy", 20);
myCar.CruncTunes(true);

try
{
    for (int i = 0; i < 10; i++)
    {
        myCar.Accelerate(10);
    }
}
catch (Exception e)
{
    Console.WriteLine("Custom Data");
    foreach( DictionaryEntry de in e.Data)
    {
        Console.WriteLine(" {0} : {1}", de.Key, de.Value);
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  )
}