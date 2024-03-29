﻿using System;

namespace Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            FindClosestPodouble(x1, y1, x2, y2);
        }

        public static void FindClosestPodouble(double x1, double y1, double x2, double y2)
        {
            double distance1 = (double)(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2))); 
            double distance2 = (double)(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)));

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
