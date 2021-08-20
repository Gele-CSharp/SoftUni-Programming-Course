using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int totalSum = 0;
            int currentSum = 0;
            int index = 0;
            bool isEqual = false;

            for (int i = 0; i < array.Length; i++)
            {
                totalSum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (currentSum == (totalSum - array[i] - currentSum))
                {
                    index = i;
                    isEqual = true;
                }

                currentSum += array[i];
            }

            if (isEqual)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
