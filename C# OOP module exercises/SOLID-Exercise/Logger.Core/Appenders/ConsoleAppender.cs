namespace Logger.Core.Appenders
{
    using Interfaces;
    using Formatting;
    using Formatting.Interfaces;
    using Formatting.Layouts.Interfaces;
    using Models.Interfaces;
    using Enums;

    public class ConsoleAppender : IAppender
    {
        private readonly IFormatter formatter;

        public ConsoleAppender()
        {
            formatter = new MessageFormatter();
        }

        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = 0) : this()
        {
            Layout = layout;
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel { get; private set; }

        public void AppendMessage(IMessage message)
        {
            Console.WriteLine(formatter.Format(message,Layout));
        }
    }
}
