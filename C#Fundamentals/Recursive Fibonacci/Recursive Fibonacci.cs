using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal fibonacciNumber = GetFibonacci(number);
            Console.WriteLine($"{fibonacciNumber}");
        }

        static decimal GetFibonacci(decimal number)
        {
            if (number <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(number - 1) + GetFibonacci(number - 2);
            }
        }
    }
}
