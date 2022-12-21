namespace Logger.Core.Exceptions
{
    using System;

    public class EmtyMessageTextException : Exception
    {
        private const string DEFAULT_MESSAGE = "Message text can not be null or emty!";

        public EmtyMessageTextException() : base(DEFAULT_MESSAGE) {  }

        public EmtyMessageTextException(string message) : base(message) { }
    }
}
