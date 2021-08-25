using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Finish")
            {
                int value = int.Parse(command[1]);

                if (command[0] == "Add")
                {
                    numbers.Add(value);
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (command[0] == "Replace")
                {
                    int newValue = int.Parse(command[2]);

                    if (numbers.Contains(value))
                    {
                        int index = numbers.IndexOf(value);
                        numbers.Insert(index, newValue);
                        numbers.Remove(value);
                    }
                }
                else if (command[0] == "Collapse")
                {
                    numbers.RemoveAll(n => n < value);
                }

                command = Console.ReadLine().Split();
            }

            Console.Write(string.Join(" ", numbers));
            Console.WriteLine();
        }
    }
}
