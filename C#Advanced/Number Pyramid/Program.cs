using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool flag = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
