using System;

namespace Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            string population = Console.ReadLine();
            string area = Console.ReadLine();

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}
