using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Word_Count_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] words = await File.ReadAllLinesAsync("words.txt");
            string[] lines = await File.ReadAllLinesAsync("text.txt");
            Dictionary<string, int> countOfWords = new Dictionary<string, int>();

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j].ToLower();

                    if (lines[i].ToLower().Contains(currentWord))
                    {
                        if(countOfWords.ContainsKey(currentWord) == false)
                        {
                            countOfWords.Add(currentWord, 0);
                        }

                        countOfWords[currentWord]++;
                    }
                }
            }

            //foreach (var word in countOfWords.OrderByDescending(c => c.Value))
            //{
            //    Console.WriteLine(word.Key);
            //}

            countOfWords.OrderByDescending(c => c.Value);
            await File.WriteAllLinesAsync("output.txt", countOfWords.OrderByDescending(c=>c.Value).Select(c => c.Key + "-" + c.Value));
        }
    }
}
