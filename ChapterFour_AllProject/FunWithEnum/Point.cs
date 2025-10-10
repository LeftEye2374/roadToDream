namespace Point
{
    public static class Poitn
    {
        struct Point
        {
            public int x;
            public int y;

            public void increment()
            {
                x++; y++;
            }

            public void decriment()
            {
                x--; y--;
            }

            public void display()
            {
                Console.WriteLine("X = {0}, Y = {1}", x,y);
            }
        }
    } 
}