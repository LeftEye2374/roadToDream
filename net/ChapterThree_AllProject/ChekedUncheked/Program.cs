class Program
{
    static void Main(String[] args)
    {
        ProcessByteCheked();
    }

    static void ProcessByteCheked()
    {
        byte b1 = 100;
        byte b2 = 250;
        try
        { 
            byte sum = checked((byte)Add(b1, b2)); 
            Console.WriteLine("Sum = {0}", sum);
        }
        catch(OverflowException e) 
        {
            Console.WriteLine(e.Message);
        }
    }

    static void ProcessByte()
    {
        byte b1 = 100;
        byte b2 = 250;
        try
        {
            byte sum = unchecked((byte)Add(b1, b2));
            Console.WriteLine("Sum = {0}", sum);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static int Add(int b1, int b2)
    {
        return b1 + b2;
    }

    static int Add(int b1, int b2)
    {
        return b1 + b2; 
    }
}