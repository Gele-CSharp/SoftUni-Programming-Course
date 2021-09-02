using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>(numberOfInputs);

            for (int i = 0; i < numberOfInputs; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonym);
                }
                else
                {
                    dictionary.Add(word, new List<string> { synonym });
                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
