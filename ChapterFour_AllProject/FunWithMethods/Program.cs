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
        Console.WriteLine("___________________________________");

        Console.WriteLine(AddOnlyRead(123123, 123123123));
        Console.ReadLine();
        Console.WriteLine("___________________________________");

        double average;
        average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
        Console.WriteLine("Average of data is: {0}", average);
        double[] data = {4.0, 3.2, 5.7};
        average = CalculateAverage(data);
        Console.WriteLine("Average of data is: {0}", average);
        Console.WriteLine("Average of data is: {0}", CalculateAverage());
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

    static int AddOnlyRead(in int num1, in int num2)
    {
        //num1 = 12312312;
        //num2 = 12312412454124;
        //int ans = num1 + num2;
        //return ans;
        int ans = num1 + num2;
        return ans;
    }

    static double CalculateAverage(params double[] values)
    {
        Console.WriteLine("You sent me: {0} doubles", values.Length);
        double sum =0;
        if(values.Length == 0)
        {
            return sum;
        }
        for(int i =0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return (sum / values.Length);

    }
}