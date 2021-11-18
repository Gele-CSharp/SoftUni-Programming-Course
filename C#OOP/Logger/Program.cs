using System;
using System.Linq;

namespace Loggers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfAppenders = int.Parse(Console.ReadLine());
            ILogger logger = new Logger();
            

            for (int i = 0; i < numberOfAppenders; i++)
            {
                IAppender appender = null;
                ILayout layout = null;

                string[] appenderInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string appenderType = appenderInfo[0];
                string layoutType = appenderInfo[1];

                if (layoutType == "SimpleLayout")
                {
                    layout = new SimpleLayout();
                }
                else if (layoutType == "XmlLayout")
                {
                    layout = new XmlLayout();
                }

                if (appenderType == "ConsoleAppender")
                {
                    appender = new ConsoleAppender(layout);
                }
                else if (appenderType == "FileAppender")
                {
                    ILogFile logFile = new LogFile();
                    appender = new FileAppender(layout, logFile);
                }

                if (appenderInfo.Length == 3)
                {
                    string report = appenderInfo[2];
                    bool isReportLevelValid = Enum.TryParse(report, true, out ReportLevel reportLevel);

                    if (isReportLevelValid)
                    {
                        appender.ReportLevel = reportLevel;
                    }
                    else
                    {
                        continue;
                    }
                }

                logger.Appenders.Add(appender);
            }

            while (true)
            {
                string[] messageInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                string report = messageInfo[0];

                if (report == "END")
                {
                    break;
                }

                string date = messageInfo[1];
                string message = messageInfo[2];

                bool isReportLevelValid = Enum.TryParse(report, true, out ReportLevel reportLevel);

                if (report == "INFO")
                {
                    logger.Info(date, message);
                }
                else if (report == "WARNING")
                {
                    logger.Warning(date, message);
                }
                else if (report == "ERROR")
                {
                    logger.Error(date, message);
                }
                else if (report == "CRITICAL")
                {
                    logger.Critical(date, message);
                }
                else if (report == "FATAL")
                {
                    logger.Fatal(date, message);
                }
            }

            Console.WriteLine("Logger info");

            foreach (var appender in logger.Appenders)
            {
                Console.WriteLine(appender.GetAppenderInfo());
            }

            var methods = logger.GetType().GetMethods();

            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
