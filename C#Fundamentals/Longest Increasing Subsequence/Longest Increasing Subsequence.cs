using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int leftmostIndex = 0;
            int subsequenceIndex = 0;
            string longestSubsequence = string.Empty;
            List<int> currentSubsequence = new List<int>(numbers.Length);
            int minNumber = int.MaxValue;
            int sequentNumber = int.MaxValue;

            currentSubsequence.Add(numbers[0]);


            for (int i = 1; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] > currentSubsequence[currentSubsequence.Count - 1])
                {

                    currentSubsequence.Add(numbers[i]);

                }
                else if ((numbers[i] < numbers[i - 1]))
                {
                    currentSubsequence.RemoveAll(x => x >= numbers[i]);
                    currentSubsequence.Add(numbers[i]);
                }
            }

            Console.Write(string.Join(" ", currentSubsequence));
            Console.WriteLine();
        }
    }
}
