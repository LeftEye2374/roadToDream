namespace CarDelegate
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

        // 1. Определить тип делегата
        public delegate void CarEngineHandler(string msgForCaller);
        // 2. Определить переменную-член этого типа делегата
        public CarEngineHandler _listOfHandlers;
        // 3. Добавить регистрационную функцию для вызывающего кода
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers = methodToCall;
        }
    }
}