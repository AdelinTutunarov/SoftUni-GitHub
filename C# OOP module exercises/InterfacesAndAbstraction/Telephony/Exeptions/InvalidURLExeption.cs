namespace Telephony.Exeptions
{
    using System;

    public class InvalidURLExeption : Exception
    {
        private const string DEAFAULT_MESSAGE = "Invalid URL!";
        public InvalidURLExeption() : base(DEAFAULT_MESSAGE) { }
        public InvalidURLExeption(string message) : base(message) { }
    }
}
