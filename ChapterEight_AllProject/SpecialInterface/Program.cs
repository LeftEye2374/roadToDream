using CustomInterfaces;
using System;

Console.WriteLine("Fun with interfaces");
Hexagon hex = new Hexagon();
Console.WriteLine("Points of hexagon: {0}", hex.Points);
Console.ReadLine();

Console.WriteLine("______________________");

Circle c = new Circle();
IPointy itpPt;
try
{
    itpPt = (IPointy) c;
    Console.WriteLine(itpPt.Points);
}
catch(InvalidCastException e) 
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();

Console.WriteLine("______________________");

Hexagon hex2  = new Hexagon("Peter");
IPointy itpPt2 = hex2 as IPointy;
if (itpPt2 != null)
{
    Console.WriteLine("Ipoints: {}", itpPt2.Points);
}
else
{
    Console.WriteLine("OOOPS");
    Console.ReadLine();
}

