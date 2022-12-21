namespace Logger.Core.Models
{
    using Interfaces;
    using Enums;
    using Exceptions;
    using Utilities;

    internal class Message : IMessage
    {
        private string? messageText;
        private string? dateTime;

        public Message(string messageText, string dateTime, ReportLevel reportLevel)
        {
            MessageText = messageText;
            DateTime = dateTime;
            ReportLevel = reportLevel;
        }



        public string MessageText
        {
            get { return messageText!; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new EmtyMessageTextException();
                messageText = value;
            }
        }


        public string DateTime
        {
            get { return dateTime!; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new EmtyDateTimeTextException();
                if (!DateTimeValidator.IsDateTimeValid(value)) throw new InvalidDateTimeFormatException();
                dateTime = value;
            }
        }


        public ReportLevel ReportLevel { get; private set; }
    }
}
