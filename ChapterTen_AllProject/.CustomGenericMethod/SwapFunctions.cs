namespace CustomGenericMethod
{
    public class SwapFunctions
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}