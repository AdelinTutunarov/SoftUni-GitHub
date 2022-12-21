namespace Logger.Core.Appenders
{
    using Interfaces;
    using IO.Interfaces;
    using Formatting;
    using Formatting.Interfaces;
    using Formatting.Layouts.Interfaces;
    using Models.Interfaces;
    using Enums;

    public class FileAppender : IAppender
    {
        private readonly IFormatter formatter;

        private FileAppender()
        {
            formatter = new MessageFormatter();
        }

        public FileAppender(ILayout layout, ILogFile logFile, ReportLevel reportLevel = 0) : this()
        {
            Layout = layout;
            ReportLevel = reportLevel;
            LogFile = logFile;
        }

        public ILayout Layout { get; private set; }

        public ILogFile LogFile { get; private set; }

        public ReportLevel ReportLevel { get; private set; }

        public void AppendMessage(IMessage message)
        {
            LogFile.WriteLine(formatter.Format(message, Layout));
            File.AppendAllText(LogFile.Path, LogFile.Content);
        }
    }
}
