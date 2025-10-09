class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2));
        Console.ReadLine();
        Console.WriteLine("___________________________________");
        int ans;
        AddUsingOutParam(90, 90, out ans);
        Console.ReadLine();
        Console.WriteLine("___________________________________");
        string s1 = "Flip";
        string s2 = "Flop";
        Console.WriteLine("Before {0} , {1}", s1, s2);
        SwapStrings(ref s1, ref s2);
        Console.WriteLine("After {0}, {1}", s1, s2);
        Console.ReadLine();
    }

    static int Add(int x, int y)
    {
        int ans = x + y;
        x = 10000;
        y = 5000;
        return ans;
    }

    // Значения выходных параметров должны быть
    // установлены внутри вызываемого метода.
    static void AddUsingOutParam(int x, int y, out int ans)
    {
        ans = x + y;
    }

    static void SwapStrings(ref string s1, ref string s2)
    {
        string tempStr = s1;
        s1 = s2;
        s2 = tempStr;
    }


}