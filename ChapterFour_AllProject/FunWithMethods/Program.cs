class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2));
        Console.ReadLine();
        Console.WriteLine("___________________________________");
        int ans;
        AddUsingOutParam(90, 90 , out ans);
        Console.ReadLine();
    }

    static int Add(int x, int y)
    {
        int ans =  x + y;
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

    static void ThisNotCompile(out int a)
    {
        Console.WriteLine("Error! Forgot to assign output arg!");
        // Ошибка! Забыли присвоить значение выходному параметру!
    }
}