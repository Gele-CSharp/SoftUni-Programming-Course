using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i].Trim();
                string removeExtraSpaces = string.Empty;
                int counter = 0;

                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] == ' ')
                    {
                        counter++;

                        if (counter > 1)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }

                    removeExtraSpaces += numbers[i][j];
                }

                numbers[i] = removeExtraSpaces;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
