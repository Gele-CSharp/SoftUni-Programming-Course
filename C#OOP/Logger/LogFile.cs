using System;
using System.Linq;
using System.Text;

namespace Loggers
{
    public class LogFile : ILogFile
    {
        private StringBuilder stringBuilder;


        public LogFile()
        {
            stringBuilder = new StringBuilder();
        }


        public int Size
            => stringBuilder.ToString().Where(x => Char.IsLetter(x)).Sum(x=> x);


        public void Write(string message)
        {
            stringBuilder.Append(message);
        }
    }
}
