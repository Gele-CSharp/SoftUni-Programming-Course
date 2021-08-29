using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string spliter = @"\s+";
            int[] array = Regex.Split(Console.ReadLine(), spliter).Select(int.Parse).ToArray();
            int topInteger = int.MinValue;
            List<int> result = new List<int>();
            bool isOnlyZeroes = true;

            for (int i = array.Length - 1; 0 < i; i--)
            {
                if (array[i] > topInteger)
                {
                    topInteger = array[i];
                    result.Add(array[i]);
                }
            }

            result.Reverse();

            foreach (int number in result)
            {
                if (number != 0)
                {
                    isOnlyZeroes = false;
                }
            }

            if (isOnlyZeroes == false)
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
