using System;
using System.IO;
using SimpleDispose;

Console.WriteLine("Fun With Dispose");
MyResourceWrapper rw =  new MyResourceWrapper();
rw.Dispose();
Console.ReadLine();