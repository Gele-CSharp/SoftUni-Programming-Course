using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(array);

            string[] command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }
                else if (command[0].ToLower() == "remove")
                {
                    int countOfNumbers = int.Parse(command[1]);

                    if(numbers.Count >= countOfNumbers)
                    {
                        for (int i = 0; i < countOfNumbers; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
