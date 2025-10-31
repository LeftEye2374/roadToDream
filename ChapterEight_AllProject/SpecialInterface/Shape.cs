namespace CustomInterfaces
{

    public interface IPointy
    {
        byte Points { get; }
    }

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

    // ___________________________________________________________

    public class Pencil() : IPointy
    {
        public byte Points => throw new NotImplementedException();
    }

    public class Switchblade() : Object, IPointy
    {
        public byte Points => throw new NotImplementedException();
    }

    public class PitchFork() : ICloneable, IPointy
    {
        public byte Points => throw new NotImplementedException();

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

    public class Fork() : Utensil, IPointy
    {
        public byte Points => throw new NotImplementedException();
    }
}