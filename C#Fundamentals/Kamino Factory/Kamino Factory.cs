using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            int numberOfSample = 0;
            int numberOfBestSample = 0;
            string currentSubsequence = string.Empty;
            string bestSubsequence = string.Empty;
            int currentSubsequnceIndex = 0;
            int leftmostIndex = 0;
            int sum = 0;
            int greatestSum = 0;
            string currentSequence = string.Empty;
            string bestSample = string.Empty;

            string input = Console.ReadLine();
            
            while (input != "Clone them!")
            {
                numberOfSample++;
                currentSequence = input.Replace("!", "");
                string[] dnaSequence = currentSequence.Split(new string[] { "0" }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i].Length > bestSubsequence.Length)
                    {
                        bestSubsequence = dnaSequence[i];
                        leftmostIndex = currentSequence.IndexOf(bestSubsequence);
                        greatestSum = dnaSequence.Length + 1;
                        numberOfBestSample = numberOfSample;
                        bestSample = currentSequence;
                    }
                    else if (dnaSequence[i].Length == bestSubsequence.Length)
                    {
                        currentSubsequence = dnaSequence[i];
                        currentSubsequnceIndex = currentSequence.IndexOf(currentSubsequence);
                        sum = dnaSequence.Length + 1;
                    }
                }

                if (currentSubsequence.Length == bestSubsequence.Length || numberOfBestSample == 1)
                {
                    if (currentSubsequnceIndex < leftmostIndex)
                    {
                        leftmostIndex = currentSubsequnceIndex;
                        bestSubsequence = currentSubsequence;
                        greatestSum = sum;
                        numberOfBestSample = numberOfSample;
                        bestSample = currentSequence;
                    }
                    else if (currentSubsequnceIndex == leftmostIndex)
                    {
                        if (sum > greatestSum)
                        {
                            bestSubsequence = currentSubsequence;
                            greatestSum = sum;
                            numberOfBestSample = numberOfSample;
                            bestSample = currentSequence;
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {numberOfBestSample} with sum: {greatestSum}.");
            Console.WriteLine(string.Join(" ", bestSample.ToArray()));
        }
    }
}
