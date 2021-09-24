using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (StreamReader streamOfWantedWords = new StreamReader("words.txt"))
            {
                string line = await streamOfWantedWords.ReadLineAsync();
                string[] wantedWords = line.Split();

                for (int i = 0; i < wantedWords.Length; i++)
                {
                    words.Add(wantedWords[i].ToLower(), 0);
                }
            }

            using (StreamReader streamOfInput = new StreamReader("Input.txt"))
            {
                string line = await streamOfInput.ReadLineAsync();
                
                while (line != null)
                {
                    string separator = @"[^a-zA-Z+\'*a-z+]";
                    string[] input = Regex.Split(line, separator);

                    for (int i = 0; i < input.Length; i++)
                    {
                        string currentWord = input[i].ToLower();

                        if (words.ContainsKey(currentWord))
                        {
                            words[currentWord]++;
                        }
                    }
                    line = await streamOfInput.ReadLineAsync();
                }
            }

            using (StreamWriter streamOutput = new StreamWriter("Output.txt"))
            {
                foreach (var word in words.OrderByDescending(w => w.Value))
                {
                    await streamOutput.WriteLineAsync($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
