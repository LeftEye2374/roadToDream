using System;
using System.Diagnostics;

Console.WriteLine("**** Fun With Processes ****");
ListAllRunningProcesses();
Console.ReadLine();


static void ListAllRunningProcesses()
{
    var runningProcs = from proc in Process.GetProcesses(".") orderby  proc.Id select proc;
    foreach (var p in runningProcs)
    {
        string info = $"-> PID: {p.Id}\t Name: {p.ProcessName}";
        Console.WriteLine(info);
    }

    Console.WriteLine("***********************************");
}