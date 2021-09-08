using System;
using System.Collections.Generic;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", new Stack<char>(Console.ReadLine())));

            //string input = Console.ReadLine();
            //Stack<string> stack = new Stack<string>(input.Length);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    string currentChar = input[i].ToString();
            //    stack.Push(currentChar);
            //}

            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //}
        }
    }
}
