using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] wantedWords = await File.ReadAllLinesAsync("words.txt");
            string[] textLines = await File.ReadAllLinesAsync("text.txt");
            Dictionary<string, int> wantedWordsCount = new Dictionary<string, int>();

            for (int i = 0; i < textLines.Length; i++)
            {
                string currentLine = textLines[i].ToLower();

                for (int j = 0; j < wantedWords.Length; j++)
                {
                    string wantedWord = wantedWords[j].ToLower();

                    if (wantedWordsCount.ContainsKey(wantedWord) == false)
                    {
                        wantedWordsCount.Add(wantedWord, 0);
                    }

                    if (currentLine.Contains(wantedWord))
                    {
                        wantedWordsCount[wantedWord]++;
                    }
                }
            }

            List<string> actualResult = new List<string>();

            foreach (var word in wantedWordsCount)
            {
                actualResult.Add($"{word.Key} - {word.Value}");
            }

            await File.WriteAllLinesAsync("actualResult.txt", actualResult);

            List<string> expectedResult = new List<string>();

            foreach (var word in wantedWordsCount.OrderByDescending(w=> w.Value))
            {
                expectedResult.Add($"{word.Key} - {word.Value}");
            }

            await File.WriteAllLinesAsync("expectedResult.txt", expectedResult);
        }
    }
}
