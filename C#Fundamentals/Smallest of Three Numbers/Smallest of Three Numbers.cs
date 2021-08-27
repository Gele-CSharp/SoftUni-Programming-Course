using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            PrintSmallestInteger(firstNumber, secondNumber, thirdNumber);
        }

        public static void PrintSmallestInteger(int fisrtNumber, int secondNumber, int thirdNumber)
        {
            int smallestInteger = int.MaxValue;

            if (fisrtNumber < smallestInteger)
            {
                smallestInteger = fisrtNumber;
            }

            if (secondNumber < smallestInteger)
            {
                smallestInteger = secondNumber;
            }

            if (thirdNumber < smallestInteger)
            {
                smallestInteger = thirdNumber;
            }

            Console.WriteLine(smallestInteger);
        }
    }
}
