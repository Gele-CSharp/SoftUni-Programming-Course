﻿using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            foreach (var word in words.Where(w=>w.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }
        }
    }
}
