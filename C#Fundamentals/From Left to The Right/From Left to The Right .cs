using System;
using System.Linq;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
                string convertedNumber = string.Empty;
                double sum = 0;

                if (numbers[0] >= numbers[1])
                {
                    convertedNumber = numbers[0].ToString();

                    for (int j = 0; j < convertedNumber.Length; j++)
                    {
                        if (convertedNumber[j] == '-')
                        {
                            continue;
                        }

                        sum += double.Parse(convertedNumber[j].ToString());
                    }
                }
                else
                {
                    convertedNumber = numbers[1].ToString();

                    for (int j = 0; j < convertedNumber.Length; j++)
                    {
                        if (convertedNumber[j] == '-')
                        {
                            continue;
                        }

                        sum += double.Parse(convertedNumber[j].ToString());
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
