using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];

            for (long i = 0; i < n; i++)
            {
                triangle[i] = new long[i + 1];
            }

            if (n > 1)
            {
                triangle[0][0] = 1;
                triangle[1][0] = 1;
                triangle[1][1] = 1;
            }
            else if (n == 1)
            {
                Console.WriteLine("1");
                return;
            }

            for (long i = 1; i < n - 1; i++)
            {
                for (long j = 0; j < i + 1; j++)
                {
                    triangle[i + 1][j] += triangle[i][j];
                    triangle[i + 1][j + 1] += triangle[i][j];
                }
            }

            for (long i = 0; i < n; i++)
            {
                for (long j = 0; j < i + 1; j++)
                {
                    Console.Write($"{triangle[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
