using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string modelOfBiggestKeg = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfKeg = 3.14 * (Math.Pow(radiusOfKeg, 2) * height);

                if (volumeOfKeg > biggestVolume)
                {
                    biggestVolume = volumeOfKeg;
                    modelOfBiggestKeg = modelOfKeg;
                }
            }

            Console.WriteLine(modelOfBiggestKeg);
        }
    }
}
