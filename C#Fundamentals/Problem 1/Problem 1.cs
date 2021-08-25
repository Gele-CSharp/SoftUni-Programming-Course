using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine());
            double quantityHay = double.Parse(Console.ReadLine());
            double quantityCover = double.Parse(Console.ReadLine());
            double weightOfPig = double.Parse(Console.ReadLine());

            for (int days = 1; days <= 30; days++)
            {
                quantityFood -= 0.3;

                if (days % 2 == 0)
                {
                    quantityHay -= quantityFood * 0.05;
                }

                if (days % 3 == 0)
                {
                    quantityCover -= weightOfPig / 3;
                }

                if (quantityFood < 0 || quantityHay < 0 || quantityCover < 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood:f2}, Hay: {quantityHay:f2}, Cover: {quantityCover:f2}.");
        }
    }
}
