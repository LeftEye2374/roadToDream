class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fun with Tuples");
        var sample = FeelTheseValues();
        Console.WriteLine(sample.a);
        Console.WriteLine(sample.b);
        Console.WriteLine(sample.c);
    }

    static (int a, string b, bool c) FeelTheseValues()
    {
        return(16,"hui", true);
    } 
}