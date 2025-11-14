using System;
using System.Threading;
using SimpleMultiThreadApp;

Console.WriteLine("Amazing Thread App");
Console.WriteLine("Do you want [1] or [2] threads?");
string threadCount = Console.ReadLine();
Thread primareyThread = Thread.CurrentThread;
primareyThread.Name = "Primary";
Console.WriteLine("--> {0} is executing Main()", Thread.CurrentThread.Name);

Printer p = new Printer();
switch (threadCount)
{
    case "2":
        Thread backGroundThread = new Thread(new ThreadStart(p.PrintNumbers));
        backGroundThread.Name = "Secondary";
        backGroundThread.Start();
        break;
    case "1":
        p.PrintNumbers();
        break;
    default:
        Console.WriteLine("I dont know what you want");
        goto case "1";
}

Console.ReadLine();
