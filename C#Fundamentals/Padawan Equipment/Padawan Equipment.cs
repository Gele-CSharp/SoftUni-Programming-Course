using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceOFLightsabre = double.Parse(Console.ReadLine());
            double priceOFRobe = double.Parse(Console.ReadLine());
            double priceOFBelt = double.Parse(Console.ReadLine());
            double price = 0;

            price += (numberOfStudents + Math.Ceiling(numberOfStudents * 0.10)) * priceOFLightsabre;
            price += numberOfStudents * priceOFRobe;

            if (numberOfStudents >= 6)
            {
                numberOfStudents -= numberOfStudents / 6;
                price += numberOfStudents * priceOFBelt;
            }
            else
            {
                price += numberOfStudents * priceOFBelt;
            }

            if (budget >= price)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {price - budget:f2}lv more.");
            }
        }
    }
}
