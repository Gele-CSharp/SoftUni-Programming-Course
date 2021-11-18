using System;
using System.IO;

namespace Loggers
{
    public class FileAppender : Appender, IFileAppender
    {
        private const string filePath = "output.txt";

        public FileAppender(ILayout layout, ILogFile logFile) 
            : base(layout)
        {
            LogFile = logFile;
        }


        public ILogFile LogFile { get; protected set; }


        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            string result = string.Format(layout.Template, date, reportLevel, message);
            File.WriteAllText(filePath, result + Environment.NewLine);
            LogFile.Write(result);
            Count++;
        }

        public override string GetAppenderInfo()
        => base.GetAppenderInfo() + $", File size: {LogFile.Size}";
    }
}
