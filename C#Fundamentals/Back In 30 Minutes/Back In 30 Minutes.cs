using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = minutes + (hours * 60) + 30;

            int hour = totalMinutes / 60;
            int min = totalMinutes % 60;

            if (hour >= 24)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour}:{min:d2}");
        }
    }
}
