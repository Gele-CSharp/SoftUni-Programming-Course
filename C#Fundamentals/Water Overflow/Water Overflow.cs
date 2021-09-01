using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int capacity = 255;

            for (int i = 0; i < numberOfLines; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());

                if (capacity - litersOfWater < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                capacity -= litersOfWater;
            }

            Console.WriteLine(255 - capacity);
        }
    }
}
