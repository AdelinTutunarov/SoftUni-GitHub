namespace Logger.Core.Exceptions
{
    public class InvalidDateTimeFormatException : Exception
    {
        private const string DEFAULT_MESSAGE = "This DateTime format is not supported!";

        public InvalidDateTimeFormatException() : base(DEFAULT_MESSAGE) { }

        public InvalidDateTimeFormatException(string message) : base(message) { }
    }
}
