using System;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string braces = Console.ReadLine();
            Stack<char> stackedBraces = new Stack<char>(braces.Length / 2);
            Queue<char> queuedBraces = new Queue<char>(braces.Length / 2);

            if (braces.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < braces.Length; i++)
            {
                if (i < braces.Length / 2)
                {
                    queuedBraces.Enqueue(braces[i]);
                }
                else if (i >= braces.Length / 2)
                {
                    stackedBraces.Push(braces[i]);
                }
            }

            while (stackedBraces.Count > 0)
            {
                char openingBrace = queuedBraces.Dequeue();
                char closingBrace = stackedBraces.Pop();
                string currentBraces = openingBrace.ToString() + closingBrace.ToString();

                if (currentBraces == "{}" || currentBraces == "[]" || currentBraces == "()")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
