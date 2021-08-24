using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var element in input)
            {
                string word = element.ToLower();

                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach (var word in words.Where(w=>w.Value % 2 != 0))
            {
                Console.Write($"{word.Key} ");
            }

            Console.WriteLine();
        }
    }
}
