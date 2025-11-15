namespace MultiThreadedPrinting
{
    public class Printer
    {
        public void PrintNumbers()
        {
            object threadLock = new object();
            lock (threadLock)
            {
                Console.WriteLine("--> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.WriteLine("{0},", i);
                }
                Console.WriteLine();
            }
        }
    }
}