using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeOfNumbers = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= rangeOfNumbers; i++)
            {
                int number = i;
                int sum = 0;
                bool isSpecialNumber = false;

                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                    isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                }

                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
            }
        }
    }
}
