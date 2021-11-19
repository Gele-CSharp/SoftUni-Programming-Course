using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 97; k < 97 + l; k++)
                    {
                        for (int x = 97; x < 97 + l; x++)
                        {
                            for (int y = 1; y <= n; y++)
                            {
                                if(y > i && y > j)
                                {
                                    Console.Write($"{i}{j}{Convert.ToChar(k)}{Convert.ToChar(x)}{y} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
