using System;

namespace Equal_Sums_Even_Odd_Position_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = num1; i <= num2; i++)
            {
                string currentNum = i.ToString();
                oddSum = 0;
                evenSum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
