using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal num3 = decimal.Parse(Console.ReadLine());

            GetSignOfProduct(num1, num2, num3);
        }

        public static void GetSignOfProduct(decimal num1, decimal num2, decimal num3)
        {
            int counter = 0;
            string sign = string.Empty;

            if (num1 < 0)
            {
                counter++;
            }
            else if (num1 == 0)
            {
                sign = "zero";
            }

            if (num2 < 0)
            {
                counter++;
            }
            else if (num2 == 0)
            {
                sign = "zero";
            }

            if (num3 < 0)
            {
                counter++;
            }
            else if (num3 == 0)
            {
                sign = "zero";
            }

            if (counter == 0 && sign != "zero")
            {
                sign = "positive";
            }
            else if (counter > 0 && counter % 2 != 0 && sign != "zero")
            {
                sign = "negative";
            }

            Console.WriteLine(sign);
        }
    }
}
