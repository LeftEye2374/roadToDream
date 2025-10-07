class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2));
        Console.WriteLine("_____________________________________________");
        Console.WriteLine(AddWrapper(1, 2));
        Console.ReadLine();
    }

    static int Add(int x, int y) => x + y;

    static int AddWrapper(int x, int y)
    {
        return Add(x, y);
        int Add(int x, int y)
        {
            return x + y;
        }
    }
}