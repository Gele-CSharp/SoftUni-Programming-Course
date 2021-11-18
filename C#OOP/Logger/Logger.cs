using System.Collections.Generic;

namespace Loggers
{
    public class Logger : ILogger
    {
        private readonly List<IAppender> appenders;


        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender>(appenders);
        }


        public List<IAppender> Appenders => appenders;


        public void Fatal(string date, string message)
        {
            Log(date, ReportLevel.FATAL, message);
        }

        public void Critical(string date, string message)
        {
            Log(date, ReportLevel.CRITICAL, message);
        }

        public void Error(string date, string message)
        {
            Log(date, ReportLevel.ERROR, message);
        }

        public void Warning(string date, string message)
        {
            Log(date, ReportLevel.WARNING, message);
        }

        public void Info(string date, string message)
        {
            Log(date, ReportLevel.INFO, message);
        }

        private void Log(string date, ReportLevel reportlevel, string message)
        {
            foreach (var appender in Appenders)
            {
                if (reportlevel >= appender.ReportLevel)
                {
                    appender.Append(date, reportlevel, message);
                }
            }
        }
    }
}
