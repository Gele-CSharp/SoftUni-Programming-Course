using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrimes = 0;
            int sumNonPrimes = 0;
            int numberOfDivides = 0;
            

            while (input != "stop")
            {
                
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        numberOfDivides++;
                    }
                }

                if (numberOfDivides == 2)
                {
                    sumPrimes += number;
                    numberOfDivides = 0;
                }
                else if (numberOfDivides > 2)
                {
                    sumNonPrimes += number;
                    numberOfDivides = 0;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimes}");
        }
    }
}
