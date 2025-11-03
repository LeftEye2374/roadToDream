using SimpleGC;
using System;

Console.WriteLine("Fun with System.GS");
Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));
Console.WriteLine("This OS has {0} object generations. \n", (GC.MaxGeneration + 1));
Car refToMyCar = new Car("Zippy", 100);
Console.WriteLine(refToMyCar.ToString());
Console.WriteLine("G\n Generation of the refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
object[] tonsOfObjects = new object[50000];
for (int i = 0; i < 50000; i++)
{
    tonsOfObjects[i] = new object();
}
Console.WriteLine("Force Garbage collector");
GC.Collect(0, GCCollectionMode.Forced);
GC.WaitForPendingFinalizers();
Console.WriteLine("Generation of the refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
if(tonsOfObjects[9000] != null)
{
    Console.WriteLine("Generation of the tonsOfObject[9000] is: {0}", GC.GetGeneration(tonsOfObjects[9000]));
}
else
{
    Console.WriteLine("tonsOfObject[9000] is no longer alive");
}
Console.WriteLine("\n Gen 0 has been swept {0} times", GC.CollectionCount(0));
Console.WriteLine("\n Gen 1 has been swept {0} times", GC.CollectionCount(1));
Console.WriteLine("\n Gen 2 has been swept {0} times", GC.CollectionCount(2));
Console.ReadLine();