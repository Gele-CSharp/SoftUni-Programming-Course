using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string first = strings[0];
            string second = strings[1];

            MultiplyStrings(first, second);
        }

        public static void MultiplyStrings(string first, string second)
        {
            int length = first.Length >= second.Length ? first.Length : second.Length;
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                if (i < first.Length && second.Length > i)
                {
                    sum += first[i] * second[i];
                }
                else if (i >= first.Length)
                {
                    sum += second[i];
                }
                else if (i >= second.Length)
                {
                    sum += first[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
