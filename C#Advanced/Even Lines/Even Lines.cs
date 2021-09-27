using System;
using System.IO;
using System.Threading.Tasks;

namespace Even_Lines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader input = new StreamReader("text.txt"))
            {
                string line = await input.ReadLineAsync();
                int lineCounter = 0;

                using (StreamWriter output = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        string[] lineParts = line.Split();

                        if (lineCounter % 2 == 0)
                        {
                            for (int i = 0; i < lineParts.Length; i++)
                            {
                                lineParts[i] = ReplaceCharacter(lineParts[i]);
                            }

                            Array.Reverse(lineParts);

                            await output.WriteLineAsync(string.Join(" ", lineParts));
                        }

                        line = await input.ReadLineAsync();
                        lineCounter++;
                    }
                }
            }
        }

        private static string ReplaceCharacter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '-':
                    case ',':
                    case '.':
                    case '!':
                    case '?':

                        text = text.Replace(text[i], '@');

                        break;
                }
            }

            return text;
        }
    }
}
