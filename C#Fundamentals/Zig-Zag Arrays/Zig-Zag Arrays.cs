using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = input[0];
                    secondArr[i] = input[1];
                }
                else
                {
                    firstArr[i] = input[1];
                    secondArr[i] = input[0];
                }
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write($"{firstArr[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < secondArr.Length; i++)
            {
                Console.Write($"{secondArr[i]} ");
            }
        }
    }
}
