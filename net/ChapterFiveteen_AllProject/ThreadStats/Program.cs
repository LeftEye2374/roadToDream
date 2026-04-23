using System;
using System.Threading;

Console.WriteLine("Primary Thread Stats");
Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "ThePrimaryThread";

Console.WriteLine("Thread name: {0}", primaryThread.Name);
Console.WriteLine("Has threads started? {0}", primaryThread.IsAlive);
Console.WriteLine("Priority Level: {0}", primaryThread.Priority);
Console.WriteLine("Thread state: {0}", primaryThread.ThreadState);
Console.ReadLine();