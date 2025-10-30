namespace Shape
{
    public abstract class Shape
    {
        protected Shape(string name = "NoName") 
        {
            PetName = name;
        }

        public string PetName { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }
}