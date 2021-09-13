using System;
using System.IO;
using System.Threading.Tasks;

namespace Odd_Lines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("Input.txt"))
            {
                string line = await str.ReadLineAsync();
                int currentLine = 0;

                using (StreamWriter ostr = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        if (currentLine % 2 != 0)
                        {
                            await ostr.WriteLineAsync(line);
                        }
                        currentLine++;
                        line = await str.ReadLineAsync();
                    }
                }
            }
        }
    }
}
