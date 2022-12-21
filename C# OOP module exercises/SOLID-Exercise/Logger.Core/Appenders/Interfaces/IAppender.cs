
namespace Logger.Core.Appenders.Interfaces
{
    using Models.Interfaces;
    using Formatting.Layouts.Interfaces;
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; }

        void AppendMessage(IMessage message);
    }
}
