namespace CustomException
{

    public class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming ..." : "Quite time..");
        }
    }
}