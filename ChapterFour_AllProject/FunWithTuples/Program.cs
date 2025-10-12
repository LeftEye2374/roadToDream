class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fun with Tuples");
        var foo = new (Prop1 = "first", Prop2 = "second");
        var bar = (foo.Prop1, foo.Prop2);
        Console.WriteLine($"{bar.Prop1}, {bar.Prop2}");
    }
}