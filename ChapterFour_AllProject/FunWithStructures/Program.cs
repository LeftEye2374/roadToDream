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