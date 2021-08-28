using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string convertedNumber = i.ToString();
                int sum = 0;
                bool isSpecial = false;

                for (int j = 0; j < convertedNumber.Length; j++)
                {
                    sum += (int)convertedNumber[j] - 48;
                    isSpecial = (sum == 5 || sum == 7 || sum == 11);
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
