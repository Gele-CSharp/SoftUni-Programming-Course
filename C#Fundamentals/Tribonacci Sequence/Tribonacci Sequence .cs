using System;
using System.Collections.Generic;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            if (num >= 4)
            {
                GetTribonacciSequence(num);
            }
            else if (num == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (num == 1)
            {
                Console.WriteLine("1");
            }
        }

        public static void GetTribonacciSequence(decimal num)
        {
            List<decimal> tribonacciNums = new List<decimal>((int)num) { 1, 1, 2};

            for (int i = 3; i < num; i++)
            {
                tribonacciNums.Add((tribonacciNums[i - 1]) + (tribonacciNums[i - 2]) + (tribonacciNums[i - 3]));
            }

            Console.WriteLine(string.Join(" ", tribonacciNums));
        }
    }
}
