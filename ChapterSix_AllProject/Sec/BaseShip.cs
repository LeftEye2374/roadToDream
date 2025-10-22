using Base;

namespace Base;

public class BaseShip 
{
    protected int _speed;

    public virtual string Move(int distance)
    {
        string result = string.Format("Пройдено километров - {0}", distance);
        return result;
    } `

    public override string ToString()
    {
        return "Poshel nahui";
    }
}

public class TransportShip : BaseShip
{
    public override string Move(int distance)
    {
        string result = string.Format("Пройдено километров  - {0} buuuueeeeee", distance);
        return result;
    }
}