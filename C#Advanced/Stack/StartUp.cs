using System;
using System.Linq;

namespace Stacks
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                if (command[0] == "Push")
                {
                    string[] elements = command.Skip(1).Select(e => e.Split(",").First()).ToArray();
                    stack.Push(elements);
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException)
                    {

                        Console.WriteLine("No elements");
                    }
                    
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
