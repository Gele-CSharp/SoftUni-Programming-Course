using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumbers(number);
        }

        public static void PrintTopNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                bool isOdd = false;
                string convertedNumber = i.ToString();

                for (int j = 0; j < convertedNumber.Length; j++)
                {
                    sum += int.Parse(convertedNumber[j].ToString());

                    if (int.Parse(convertedNumber[j].ToString()) % 2 != 0)
                    {
                        isOdd = true;
                    }
                }

                if (sum % 8 == 0 && isOdd)
                {
                    Console.WriteLine(convertedNumber);
                }
            }
        }
    }
}
