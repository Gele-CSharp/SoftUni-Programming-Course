using System;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            int houseIndex = 0;

            while (command[0] != "Love!")
            {
                int jump = int.Parse(command[1]);
                houseIndex += jump;

                if (houseIndex >= neighborhood.Length)
                {
                    houseIndex = 0;
                }

                if (neighborhood[houseIndex] == 0)
                {
                    Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                }
                else
                {
                    neighborhood[houseIndex] -= 2;

                    if (neighborhood[houseIndex] == 0)
                    {
                        Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {houseIndex}.");

            int[] housesWithoutValentine = neighborhood.Where(x => x > 0).ToArray();

            if (housesWithoutValentine.Length == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {housesWithoutValentine.Length} places.");
            }
        }
    }
}
