using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double maxBonus = double.MinValue;
            int maxAttendances = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());
                totalBonus += Math.Round(1.0 * studentAttendances / numberOfLectures * (5 + additionalBonus));


                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendances = studentAttendances;
                }

                totalBonus = 0;
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
