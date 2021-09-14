using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int number = input[i];

                if (number % 2 == 0)
                {
                    numbers.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
