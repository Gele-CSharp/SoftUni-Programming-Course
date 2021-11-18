namespace Loggers
{
    public interface IAppender
    {
        public ReportLevel ReportLevel { get; set; }


        public int Count { get; }


        public void Append(string date, ReportLevel reportLevel, string message);


        public virtual string GetAppenderInfo()
        => string.Empty;
            
    }
}
