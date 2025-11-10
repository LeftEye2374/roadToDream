namespace CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool _carIsDead;

        public Car() {}
        public Car(string petName,  int maxSp, int currSp)
        {
            PetName = petName;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }
}