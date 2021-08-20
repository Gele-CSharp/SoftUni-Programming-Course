using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            if (secondNumber > 0)
            {
                DivideFactorials(CalculateFactorial(firstNumber), CalculateFactorial(secondNumber));
            }
        }

        private static decimal CalculateFactorial(decimal number)
        {
            decimal factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void DivideFactorials(decimal firstFactorial, decimal secondFactorial)
        {
            decimal result = (firstFactorial / secondFactorial);

            Console.WriteLine($"{result:f2}");
        }
    }
}
