namespace Shape
{
     abstract class Shape
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

    class Circle : Shape 
    {
        public Circle() { }

        public Circle(string name) : base(name){ }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }

    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public override void Draw() 
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }

    class ThreeDCircle() : Circle
    {
        public new string PetName { get; set; }

        public new void Draw() 
        {
            Console.WriteLine("Drawing 3D Circle");
        }
    }
}