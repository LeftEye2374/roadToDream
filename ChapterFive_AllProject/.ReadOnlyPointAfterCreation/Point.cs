namespace Objectlnitializers;

public class Point
{
    public int X { get; init; }
    public int Y { get; init; }
    public PointColorEnum Color { get; set; }

    public Point(int xVal, int yVal)
    {
        X = xVal;
        Y = yVal;
        Color = PointColorEnum.Gold;
    }

    public Point(PointColorEnum color)
    {
        Color = color;
    }
    
    public Point() : this(PointColorEnum.BloodRed){}

    public void DisplayStats()
    {
        Console.WriteLine("[{0}, {1}]" ,X ,Y);
        Console.WriteLine("Color is - {0}", Color);
    }
}