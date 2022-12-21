namespace Logger.Core.Exceptions
{
    using System;

    public class EmtyDateTimeTextException : Exception
    {
        private const string DEFAULT_MESSAGE = "DateTime text can not be null or emty!";

        public EmtyDateTimeTextException() : base(DEFAULT_MESSAGE) { }

        public EmtyDateTimeTextException(string message) : base(message) { }
    }
}
