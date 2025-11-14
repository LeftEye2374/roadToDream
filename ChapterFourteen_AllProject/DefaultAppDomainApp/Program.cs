using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

Console.WriteLine("Fun with Domain");
DisplayDADStats();
Console.ReadLine();


static void DisplayDADStats()
{
    AppDomain defaultDM = AppDomain.CurrentDomain;
    Console.WriteLine("Name of this Domain: {0}", defaultDM.FriendlyName);
    Console.WriteLine("ID of this Domain: {0}", defaultDM.Id);
    Console.WriteLine("Is this default domain? {0}", defaultDM.IsDefaultAppDomain());
    Console.WriteLine("Base directory of this domain: {0}", defaultDM.BaseDirectory);
    Console.WriteLine("Setup information of this domain: {0}", defaultDM.SetupInformation);

}