using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> sortedNumbers = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double number = numbers[i];

                if (sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers[number]++;
                }
                else
                {
                    sortedNumbers.Add(number, 1);
                }
            }

            foreach (var number in sortedNumbers.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
