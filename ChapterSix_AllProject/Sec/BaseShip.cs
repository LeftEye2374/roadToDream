using Base;

namespace Base;

public class BaseShip 
{
    private int _counter;
    protected int _speed;

    public BaseShip()
    {
        Console.WriteLine("Base ship was created");
    }


    public string Move(int distance)
    {
        _counter++;
        string result = string.Format("Пройдено километров - {0}", distance);
        return result;
    }
}

public class TransportShip : BaseShip
{

    public TransportShip() 
    {
        Console.WriteLine("Transport ship was created");
    }

    public void start()
    {

    }
}