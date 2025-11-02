namespace SimpleGS
{
    public class Car
    {
        public int CurrentSpered { get; set; }
        public string PetName { get; set; }
        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpered = speed;
        }

        public override string ToString() =>
            $"{PetName} is going with {CurrentSpered} MPH";
    }
}