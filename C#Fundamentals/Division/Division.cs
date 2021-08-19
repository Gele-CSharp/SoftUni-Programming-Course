using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] dividers = new int[] { 2, 3, 6, 7, 10 };
            int maxDivider = int.MinValue;
            bool isDivisible = false;

            for (int i = 0; i < dividers.Length; i++)
            {
                if (number % dividers[i] == 0)
                {
                    isDivisible = true;

                    if (dividers[i] > maxDivider)
                    {
                        maxDivider = dividers[i];
                    }
                }
            }

            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by {maxDivider}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
