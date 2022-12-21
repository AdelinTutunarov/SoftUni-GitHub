namespace Logger.Core.Exceptions
{
    public class InvalidFileNameException : Exception
    {
        private const string DEFAULT_MESSAGE = "File name can not be null or empty!";

        public InvalidFileNameException() : base(DEFAULT_MESSAGE) { }

        public InvalidFileNameException(string message) : base(message) { }
    }
}
