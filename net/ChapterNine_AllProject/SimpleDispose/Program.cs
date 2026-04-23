using System;
using FinalizableDisposableClass;

Console.WriteLine("Dispose()/ Destructor Combo Platter");
MyResourceWrapper rw  = new MyResourceWrapper();
rw.Dispose();
MyResourceWrapper rw2 = new MyResourceWrapper();