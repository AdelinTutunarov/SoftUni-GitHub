﻿namespace Logger.Core.Logging
{
    using Interfaces;
    using Appenders.Interfaces;
    using Models.Interfaces;
    using Enums;
    using Models;

    public class Logger : ILogger
    {
        private readonly ICollection<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Info(string dateTime, string message)
        {
            Append(dateTime, message, ReportLevel.Info);
        }
        public void Warning(string dateTime, string message)
        {
            Append(dateTime, message, ReportLevel.Warning);
        }
        public void Error(string dateTime, string message)
        {
            Append(dateTime, message, ReportLevel.Error);
        }

        public void Critical(string dateTime, string message)
        {
            Append(dateTime, message, ReportLevel.Critical);
        }

        public void Fatal(string dateTime, string message)
        {
            Append(dateTime, message, ReportLevel.Fatal);
        }

        private void Append(string dateType, string messageText, ReportLevel reportLevel)
        {
            IMessage message = new Message(messageText, dateType, reportLevel);
            foreach (var appender in appenders)
            {
                if (message.ReportLevel >= appender.ReportLevel)
                {
                    appender.AppendMessage(message);
                }
            }
        }

    }
}
