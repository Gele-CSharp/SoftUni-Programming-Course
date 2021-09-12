using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int index = i;

                if (currentChar == '(')
                {
                    indexes.Push(index);
                }
                else if (currentChar == ')')
                {
                    int startIndex = indexes.Pop();
                    string substring = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
