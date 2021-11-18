using System;

namespace Loggers
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            string result = string.Format(layout.Template, date, reportLevel, message);

            if (reportLevel >= ReportLevel)
            {
                Console.WriteLine(result);
                Count++;
            }
        }
    }
}
