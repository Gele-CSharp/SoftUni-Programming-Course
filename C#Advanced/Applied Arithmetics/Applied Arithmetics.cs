using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> multiply = (a, b) => a * b;
            Func<int, int, int> subtract = (a, b) => a - b;
            Action<int> print = number => Console.Write($"{number} ");
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(n => add(n, 1)).ToList();
                        break;
                    case "multiply":
                        numbers = numbers.Select(n => multiply(n, 2)).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(n => subtract(n, 1)).ToList();
                        break;
                    case "print":
                        numbers.ForEach(n => print(n));
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
