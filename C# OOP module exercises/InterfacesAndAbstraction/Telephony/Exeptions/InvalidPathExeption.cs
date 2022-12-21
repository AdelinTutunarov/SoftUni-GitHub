namespace Telephony.Exeptions
{
    using System;
    public class InvalidPathExeption : Exception
    {
        private const string DEFAULT_MESSAGE = "Invalid Path!";
        public InvalidPathExeption() : base(DEFAULT_MESSAGE) { }
        public InvalidPathExeption(string message) : base(message) { }
    }
}
