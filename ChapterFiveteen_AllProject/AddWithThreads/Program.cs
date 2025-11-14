using System;
using System.Threading;
using AddWithThreads;

Console.WriteLine("Adding with Thread object");
Console.WriteLine("ID of thread Main(): {0}", Thread.CurrentThread.ManagedThreadId);
AddParams ap = new AddParams(10, 10);
Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);
Thread.Sleep(5);
Console.ReadLine();


static void Add(object data)
{
    if (data is AddParams ap)
    {
        Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("{0} + {1} = {2}", ap.a, ap.b, ap.a + ap.b);
    }
}