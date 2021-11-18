using System;

namespace Loggers
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }


        public int Count { get; protected set; }


        public ReportLevel ReportLevel { get; set; }


        public virtual string GetAppenderInfo()
         => $"Appender type: {this.GetType().Name}, Layout type: {layout.GetType().Name}, " +
            $"Report level: {ReportLevel}, Messages appended: {Count}";


        public abstract void Append(string date, ReportLevel reportLevel, string message);
    }
}
