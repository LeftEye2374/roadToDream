using System;

namespace SimpleException
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming ..." : "Quite time..");
        }
    }


    class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // ”казывает не вышел ли автомобиль из стро€?
        private bool _carIsDead;

        private readonly Radio _theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CruncTunes(bool State)
        {
            _theMusicBox.TurnOn(State);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine("{0} is out of order ...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine("=> CurrentSpedd = {0} ", CurrentSpeed);
                }
            }
        }
    }
}
