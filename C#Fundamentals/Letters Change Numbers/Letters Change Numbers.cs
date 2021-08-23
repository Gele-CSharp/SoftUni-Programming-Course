using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            double totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                double number = double.Parse(input[i].Substring(1, input[i].Length - 2));
                string currentString = input[i];
                char firstLetter = currentString[0];
                char secondLetter = currentString[currentString.Length - 1];
                int valueOfFirstLetter = 0;
                int valueOfSecondLetter = 0;

                if (char.IsUpper(firstLetter))
                {
                    valueOfFirstLetter = Convert.ToInt32(firstLetter) - 64;
                    result += number / valueOfFirstLetter;
                }
                else if (char.IsLower(firstLetter))
                {
                    valueOfFirstLetter = Convert.ToInt32(firstLetter) - 96;
                    result += number * valueOfFirstLetter;
                }

                if (char.IsUpper(secondLetter))
                {
                    valueOfSecondLetter = Convert.ToInt32(secondLetter) - 64;
                    result -= valueOfSecondLetter; 
                }
                else if (char.IsLower(secondLetter))
                {
                    valueOfSecondLetter = Convert.ToInt32(secondLetter) - 96;
                    result += valueOfSecondLetter;
                }

                totalSum += result;
                result = 0;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
