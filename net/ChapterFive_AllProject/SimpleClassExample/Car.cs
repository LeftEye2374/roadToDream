namespace SimpleClassExample;

public class Car
{
    public string petName;
    public int currSpeed;

    public Car(string petName, int currSpeed)
    {
        this.petName = petName;
        this.currSpeed = currSpeed;
    }

    public Car(){}
    
    public void SpeedUp(int delta)
    {
        currSpeed += delta;
    }

    public void PrintState()
    {
        Console.WriteLine("{0} is going {1} MPH." , petName, currSpeed);
    }

}
 