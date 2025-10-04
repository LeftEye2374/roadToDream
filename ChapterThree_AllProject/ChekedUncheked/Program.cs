class Program
{
    static void Main(String[] args)
    {

    }

    static void ProcessByte()
    {
        byte b1 = 100;
        byte b2 = 250;
        byte sum = byte(Add(b1, b2));
        Console.WriteLine("Sum = {0}", sum);
    }

    static int Add(int b1, int b2)
    {
        return b1 + b2; 
    }
}