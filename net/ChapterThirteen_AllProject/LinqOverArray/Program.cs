using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Linq return values");
IEnumerable<string> subset = GetStringsSubset();
foreach( string item in subset)
{
    Console.WriteLine(item);
}
Console.ReadLine();

static IEnumerable<string> GetStringsSubset()
{
    string[] colors = {"Light Red", "Green","Yellow", "Dark Red", "Red", "Purple"};
    IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
    return theRedColors;
}