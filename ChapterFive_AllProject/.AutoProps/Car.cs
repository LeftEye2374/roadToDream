namespace AutoProps;

public class Car
{
    public string PetName {get; set;}
    public int Speed {get; set;}
    public string Color {get; set;}

    public void DisplayStats()
    {
        Console.WriteLine("Car name : {0}", PetName);
        Console.WriteLine("Car speed: {0}", Speed);
        Console.WriteLine("Car color: {0}", Color);
    }
}