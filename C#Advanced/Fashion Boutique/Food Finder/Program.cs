using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vowels = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<string> consonats = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Dictionary<string, string> words = new Dictionary<string, string>()
            {
                { "pear", "" },
                { "flour", "" },
                { "pork", "" },
                { "olive", "" }
            };

            List<string> listOfWords = new List<string>() { "pear", "flour", "pork", "olive" };

            while(consonats.Count > 0)
            {
                for (int i = 0; i < listOfWords.Count; i++)
                {
                    if (listOfWords[i].Contains(vowels.Peek()) && words[listOfWords[i]].Contains(vowels.Peek()) == false)
                    {
                        words[listOfWords[i]] += vowels.Peek();
                    }

                    if (listOfWords[i].Contains(consonats.Peek()) && words[listOfWords[i]].Contains(consonats.Peek()) == false)
                    {
                        words[listOfWords[i]] += consonats.Peek();
                    }
                }

                vowels.Enqueue(vowels.Dequeue());
                consonats.Pop();
            }

            Dictionary<string, string> result = words.Where(w => w.Value.Length == w.Key.Length).ToDictionary(w => w.Key, w => w.Value);

            Console.WriteLine($"Words found: {result.Count}");

            foreach (var word in result)
            {
                Console.WriteLine(word.Key);
            }
        }
    }
}
