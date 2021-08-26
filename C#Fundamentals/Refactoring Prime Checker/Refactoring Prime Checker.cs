using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());

            for (int number = 2; number <= lastNumber; number++)
            {
                bool isPrime = true;

                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", number, isPrime == true ? "true" : "false");
            }
        }
    }
}
