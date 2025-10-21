using Base;

namespace Base;

public class BaseShip 
{
    private int _counter;
    protected int _speed;

    public string Move(int distance)
    {
        _counter++;
        string result = string.Format("Пройдено километров - {0}", distance);
        return result;
    }
}

public class TransportShip : BaseShip
{
    public void start()
    {

    }
}