using System;
using System.Collections.Generic;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> values = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentValue = input[i];

                if (values.ContainsKey(currentValue) == false)
                {
                    values.Add(currentValue, 0);
                }

                values[currentValue]++;
            }

            foreach (var value in values)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
