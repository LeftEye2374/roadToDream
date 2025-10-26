namespace CustomException
{
    public class CustomException : ApplicationException
    {
        
    }

    public class CarIsDeadException : ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfException { get; set; }

        public CarIsDeadException(string message, string cause, DateTime timeStamp)
        {
            _messageDetails = message;
            CauseOfException = cause;
            ErrorTimeStamp = timeStamp;
        }
        
        public override string Message => $"Car Error: {_messageDetails}";
    }
}