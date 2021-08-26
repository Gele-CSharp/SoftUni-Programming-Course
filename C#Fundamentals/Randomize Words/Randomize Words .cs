using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random rnd = new Random();

            words = words.OrderBy(x => rnd.Next()).ToList();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
