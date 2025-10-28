namespace CustomException
{
    public class CustomException : ApplicationException
    {
        
    }

    public class CarIsDeadException : ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }

        public CarIsDeadException(string cause, DateTime time, string message ) : this(cause, time, time, message, String.Empty)
        { }

        public CarIsDeadException(string cause, DateTime time , string message, System.Exception inner) : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}