using System;
using System.Diagnostics;

Console.WriteLine("**** Fun With Processes ****");
ListAllRunningProcesses();
GetSpecificProcess();

Console.WriteLine("Enter PID of process ");
Console.Write("PID: ");
string pid = Console.ReadLine();
int pId = int.Parse(pid);
EnumThreadsForPid(pId);

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

static void GetSpecificProcess()
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(20466);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine("***********************************");
}

static void EnumThreadsForPid(int pID)
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(pID);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
    Console.WriteLine("Here are threads used by: {0}", theProc.ProcessName);
    ProcessThreadCollection theThreads = theProc.Threads;
    foreach (ProcessThread pt in theThreads)
    {
        string info = $"-> Thread ID: {pt.Id}\t Start time: {pt.StartTime.ToShortTimeString()}\t Priority: {pt.PriorityLevel} ";
        Console.WriteLine(info);
    }
    Console.WriteLine("***********************************");
}