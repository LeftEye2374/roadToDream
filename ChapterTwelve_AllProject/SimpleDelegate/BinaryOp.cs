namespace SimpleDeligate
{
    sealed class BinaryOp : System.MulticastDelegate
    {
        public int Invoke(int x, int y);
    }
}