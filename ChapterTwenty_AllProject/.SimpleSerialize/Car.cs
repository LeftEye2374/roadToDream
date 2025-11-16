namespace SimpleSerialize
{
    public class Car
    {
        public Radio TheRadio = new Radio();
        public bool IsHatchBack;
        public override string ToString()
        {
            return $"IsHatchBack: {IsHatchBack}, Radio: {TheRadio.ToString()}";
        }
    }
}