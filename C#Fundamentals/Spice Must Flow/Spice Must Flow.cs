using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeld = int.Parse(Console.ReadLine());
            int numberOfDays = 0;
            int totalYeld = 0;

            while (startingYeld >= 100)
            {
                numberOfDays++;
                totalYeld += startingYeld;
                startingYeld -= 10;
                totalYeld -= 26;
            }

            if (totalYeld - 26 >= 0)
            {
                totalYeld -= 26;
            }

            Console.WriteLine(numberOfDays);
            Console.WriteLine(totalYeld);
        }
    }
}
