﻿using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
