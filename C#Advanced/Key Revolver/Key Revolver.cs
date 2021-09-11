using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            List<int> bulletsInfo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] locksInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksInfo);
            Stack<int> bullets = new Stack<int>(bulletsInfo);
            int numberOfBullets = 0;

            while (locks.Count > 0 && bullets.Count > 0)
            {
                if (bullets.Pop() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                numberOfBullets++;

                if (numberOfBullets % gunBarrelSize == 0 && locks.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Count == 0)
            {
                int earnedMoney = intelligenceValue - (bulletPrice * numberOfBullets);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
