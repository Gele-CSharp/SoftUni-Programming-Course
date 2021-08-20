using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            double numberOfCourses = Math.Ceiling(numberOfPeople / capacityOfElevator);

            Console.WriteLine(numberOfCourses);
        }
    }
}
