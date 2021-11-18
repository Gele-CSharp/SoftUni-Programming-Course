namespace Loggers
{
    public interface IFileAppender
    {
        ILogFile LogFile { get; }
    }
}
