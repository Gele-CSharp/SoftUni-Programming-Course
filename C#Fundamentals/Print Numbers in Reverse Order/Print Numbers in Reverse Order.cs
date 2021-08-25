using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[(numbers.Length - 1) - i] = number;
            }

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
