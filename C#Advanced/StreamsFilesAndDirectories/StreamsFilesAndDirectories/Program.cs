using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Even_Lines_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using StreamReader input = new StreamReader("text.txt");
            string line = await input.ReadLineAsync();
            int lineIndex = 0;

            while (line != null)
            {
                if (lineIndex % 2 == 0)
                {
                    string charsToReplace = "-,.!?";

                    for (int i = 0; i < line.Length; i++)
                    {
                        char currentChar = line[i];

                        if (charsToReplace.Contains(currentChar))
                        {
                            line = line.Replace(currentChar, '@');
                        }
                    }

                    string[] lineParts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Array.Reverse(lineParts);

                    Console.WriteLine(string.Join(" ", lineParts));
                }

                lineIndex++;
                line = await input.ReadLineAsync();
            }
        }
    }
}

