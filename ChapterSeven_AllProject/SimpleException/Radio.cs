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

        // ????????? ?? ????? ?? ?????????? ?? ??????
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
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if( CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    throw new Exception($"{PetName} has overheated!")
                    {
                        HelpLink = "www.CarPlus.ru",
                        Data = {
                            {   "TimeStamp", $"The car exploaded at {DateTime.Now}"},
                            {   "Cause", "You have a lead foot." }
                        }
                    };
                }
                Console.WriteLine("Current speed = {0}", CurrentSpeed);
            }
        }
    }
}
