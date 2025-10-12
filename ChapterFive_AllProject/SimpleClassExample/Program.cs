using System;
using SimpleClassExample;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.petName = "hui";
        myCar.currSpeed = 200;
        
        myCar.PrintState();
        Console.WriteLine("____________________");
        myCar.SpeedUp(40);
        myCar.PrintState();
    }
}