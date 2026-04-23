using System;
using CustomInteface;

Console.WriteLine("A First Look at Interfaces");
CloneableExample();
Console.ReadLine();


static void CloneableExample()
{
    string myStr = "Hello";
    OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
    CloneMe(myStr);
    CloneMe(unixOS);

    static void CloneMe(ICloneable c)
    {
        object theClone = c.Clone();
        Console.WriteLine("Your clone is a: {0}",
        theClone.GetType().Name);
    }
}