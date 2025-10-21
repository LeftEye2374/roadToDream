using Base;
using System;

class Program
{
    static void Main(string[] args)
    {
        BaseShip baseShip = new TransportShip();
        string res = baseShip.Move(12);
        Console.WriteLine(res);
        Console.ReadLine();
    }
}