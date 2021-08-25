using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[][] array = new int[number][];

            for (int i = 0; i <= number - 1; i++)
            {
                array[i] = new int[i + 1];
            }

            array[0][0] = 1;

            for (int i = 0; i < number - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    array[i + 1][j] += array[i][j];
                    array[i + 1][j + 1] += array[i][j];
                }
            }

            for (int i = 0; i < number; i++)
            {
                //Console.WriteLine("".PadLeft(5));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
