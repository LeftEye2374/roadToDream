using System;
using System.Threading;

Console.WriteLine("Working with timer type");
TimerCallback timerCB = new TimerCallback(PrintTime);

Timer t = new Timer(timerCB,null,0,1000);
Console.WriteLine("Hit key to terminate");
Console.ReadLine();
static void PrintTime(object state)
{
    Console.WriteLine("Time is: {0}", DateTime.Now.ToLongDateString());
}
