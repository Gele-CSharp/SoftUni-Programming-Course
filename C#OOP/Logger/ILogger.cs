using System.Collections.Generic;

namespace Loggers
{
    public interface ILogger
    {
        public List<IAppender> Appenders { get; }

        public void Info(string date, string messag);

        public void Warning(string date, string messag);

        public void Error(string date, string messag);

        public void Critical(string date, string messag);

        public void Fatal(string date, string messag);
        
    }
}
