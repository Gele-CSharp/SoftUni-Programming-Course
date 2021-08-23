using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int reminder = 0;
            int currentDigitOfResult = 0;

            if (int.Parse(secondNumber) == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNumber.Length - 1; 0 <= i; i--)
            {
                int digit = Convert.ToInt32(firstNumber[i]) - 48;
                int multiplier = int.Parse(secondNumber);
                int currentResult = digit * multiplier + reminder;

                if (i == 0)
                {
                    currentDigitOfResult = currentResult;
                    char[] reversed = result.ToString().ToCharArray().Reverse().ToArray();
                    result.Clear();
                    result.Append(currentDigitOfResult.ToString());
                    result.Append(string.Join("", reversed));
                    break;
                }
                else if (currentResult > 9)
                {
                    currentDigitOfResult = currentResult % 10;
                    reminder = currentResult / 10;
                }
                else
                {
                    currentDigitOfResult = currentResult;
                    reminder = 0;
                }

                result.Append(currentDigitOfResult.ToString());
            }

            Console.WriteLine(result.ToString());
        }
    }
}
