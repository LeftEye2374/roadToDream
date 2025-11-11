namespace CarEvents
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }
        private bool _carIsDead;

        public Car() { }
        public Car(string petName, int maxSp, int currSp)
        {
            PetName = petName;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }

        public delegate void CarEngineHandler(string messageForCaller);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public CarEngineHandler ListOfHandlers;

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Exploded?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                if(10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke("Curreful buddy! Car is blow");
                }
                if(CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine("Current speed = {0}", CurrentSpeed);
                }
            }
        }
    }
}