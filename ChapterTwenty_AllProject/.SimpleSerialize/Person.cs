namespace SimpleSerialize
{
    public class Person
    {
        public bool IsAlive;
        private int PersonAge = 21;
        private string _fName = string.Empty;

        public string FirstName
        {
            get {return _fName;}
            set {_fName = value;}
        }

        public override string ToString()
        {
            return $"IsAlive: {IsAlive}, FirstName: {FirstName}, PersonAge: {PersonAge}";
        }
    }
}