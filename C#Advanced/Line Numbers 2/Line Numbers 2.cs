using System;
using System.IO;
using System.Threading.Tasks;

namespace Line_Numbers_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] lines = await File.ReadAllLinesAsync("text.txt");
            string lineToPrint = string.Empty;

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = 0;
                int puctuationMarksCount = 0;

                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (Char.IsLetter(lines[i][j]))
                    {
                        lettersCount++;
                    }
                    else if (Char.IsPunctuation(lines[i][j]))
                    {
                        puctuationMarksCount++;
                    }
                }

                lineToPrint = $"Line {i + 1}: {lines[i]} ({lettersCount})({puctuationMarksCount})";
                lines[i] = lineToPrint;
            }

            await File.WriteAllLinesAsync("output.txt", lines);
        }
    }
}
