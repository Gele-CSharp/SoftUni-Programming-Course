using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());

            Substract(Sum(firstInteger, secondInteger), thirdInteger);
        }

        public static int Sum(int firstInteger, int secondInteger)
        {
            int sum = firstInteger + secondInteger;
            return sum;
        }

        public static void Substract(int sum, int thirdInteger)
        {
            Console.WriteLine(sum - thirdInteger);
        }
    }
}
