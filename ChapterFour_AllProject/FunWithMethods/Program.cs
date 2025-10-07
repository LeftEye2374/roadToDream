class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2));
        Console.ReadLine();
    }
    
    static int Add(int x, int y)
    {
        int ans =  x + y;
        x = 10000;
        y = 5000;
        return ans;
    }
}