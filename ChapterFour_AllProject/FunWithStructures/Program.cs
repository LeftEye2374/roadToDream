Point myPoint;

myPoint.X = 349;
myPoint.Y = 76;
myPoint.display();
Console.WriteLine("_____________________");

myPoint.increment();
myPoint.display();
Console.WriteLine("_____________________");

myPoint.decrement();
myPoint.display();
Console.ReadLine();



struct Point
{
    public int X;
    public int Y;

    public void increment()
    {
        X++; Y++;
    }

    public void decrement()
    {
        X--; Y--;
    }

    public void display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X,Y);
    }
}