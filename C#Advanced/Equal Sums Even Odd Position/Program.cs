using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            int counter = 0;
            int digit = 0;

            for (int i = num1; i <= num2; i++)
            {
                int currentNumber = i;

                while (counter < 6)
                {
                    
                    digit = currentNumber % 10;

                    if (counter % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                    currentNumber /= 10;
                    counter++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
                counter = 0;
                evenSum = 0;
                oddSum = 0;
            }

        }
    }
}
