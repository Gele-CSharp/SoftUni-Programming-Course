using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Line_Numbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] lines = await File.ReadAllLinesAsync("text.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {
                string currentline = lines[i];
                int numberOfLetters = 0;
                int numberOfPunctuals = 0;

                for (int j = 0; j < currentline.Length; j++)
                {
                    char currentChar = currentline[j]; 

                    if (Char.IsLetter(currentChar))
                    {
                        numberOfLetters++;
                    }
                    else if (Char.IsPunctuation(currentChar))
                    {
                        numberOfPunctuals++;
                    }
                }

                string lineToPrint = $"Line {i + 1}: {currentline} ({numberOfLetters})({numberOfPunctuals})";
                lines[i] = lineToPrint;
            }

            await File.WriteAllLinesAsync("output.txt", lines);
        }
    }
}
