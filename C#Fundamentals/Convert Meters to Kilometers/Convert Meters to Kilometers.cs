using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometres = meters / 1000;

            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
