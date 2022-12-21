namespace Logger
{
    using Logger.Core.Appenders;
    using Logger.Core.IO;
    using Logger.Core.Formatting.Layouts;

    internal class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);

            var file = new LogFile("log.txt", "../../../Logs");
            var fileAppender = new FileAppender(simpleLayout, file);

            var logger = new Logger.Core.Logging.Logger(consoleAppender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

        }
    }
}