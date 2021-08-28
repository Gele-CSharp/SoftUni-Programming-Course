using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string convertedNumber = number.ToString();
            int sum = 0;

            for (int i = 0; i < convertedNumber.Length; i++)
            {
                int digit = (int)(convertedNumber[i] - 48);
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
