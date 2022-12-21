namespace Logger.Core.Exceptions
{
    public class InvalidPathException : Exception
    {
        private const string DEFAULT_MESSAGE = "File path does not exist!";

        public InvalidPathException() : base(DEFAULT_MESSAGE) { }

        public InvalidPathException(string message) : base(message) { }
    }
}
