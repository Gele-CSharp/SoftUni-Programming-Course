using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = Convert.ToInt32(number[i] - 48);
                int factorial = 1;

                for (int j = 1; j <= digit; j++)
                {
                    factorial *= j;
                }

                sum += factorial;
            }

            if (int.Parse(number) == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
