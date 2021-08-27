using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            decimal bestSnowballSnow = 0;
            decimal bestSnowballTime = 0;
            decimal bestSnowballQuality = 0;
            decimal bestSnowballPoints = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                decimal snowballSnow = decimal.Parse(Console.ReadLine());
                decimal snowballTime = decimal.Parse(Console.ReadLine());
                decimal snowballQuality = decimal.Parse(Console.ReadLine());

                decimal snowballTotalPoints = (decimal)(Math.Pow((double)(snowballSnow / snowballTime), (double)snowballQuality));

                if (snowballTotalPoints > bestSnowballPoints)
                {
                    bestSnowballPoints = snowballTotalPoints;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballPoints} ({bestSnowballQuality})");
        }
    }
}
