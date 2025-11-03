using SimpleGC;
using System;

Console.WriteLine("Fun with System.GS");
Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));
Console.WriteLine("This OS has {0} object generations. \n", (GC.MaxGeneration + 1));
Car refToMyCar = new Car("Zippy", 100);
Console.WriteLine(refToMyCar.ToString());
Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
Console.ReadLine();