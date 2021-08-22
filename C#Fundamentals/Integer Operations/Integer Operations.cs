using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            if (thirdNumber != 0)
            {
                Console.WriteLine(forthNumber * (int)((firstNumber + secondNumber) / thirdNumber));
            }
        }
    }
}
