using Base;
using System;

class Program
{
    static void Main(string[] args)
    {

        TransportShip ship = new TransportShip();
        string rs = ship.Move(214);
        Console.WriteLine(rs);
        Console.ReadLine();
    }
}