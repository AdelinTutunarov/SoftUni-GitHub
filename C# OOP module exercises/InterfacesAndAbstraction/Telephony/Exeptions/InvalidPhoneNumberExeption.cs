namespace Telephony.Exeptions
{
    using System;
    public class InvalidPhoneNumberExeption : Exception
    {
        private const string DEFAULT_MESSAGE = "Invalid number!";


        public InvalidPhoneNumberExeption() : base(DEFAULT_MESSAGE) { }

        public InvalidPhoneNumberExeption(string message) : base(message) { }
    }
}
