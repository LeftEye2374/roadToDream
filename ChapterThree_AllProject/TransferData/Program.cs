class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Fun with type conv");
        short num1 = 30000, num2 = 30000;
        short answer = (short)Add(num1, num2);
        Console.WriteLine("{0} + {1} = {2}", num1, num2, answer );
        NarrowingAttemp();
        Console.ReadLine();
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static vodi NarrowingAttemp()
    {
        byte myByte = 0;
        int mylnt = 200;
        myByte = (byte)mylnt;
        Console.WriteLine("Value of myByte: {0}", myByte);
    }
}