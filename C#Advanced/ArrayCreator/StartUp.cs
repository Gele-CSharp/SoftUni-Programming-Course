using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] integers = ArrayCreator.Create(1, 0);
            bool[] bools = ArrayCreator.Create(10, true);
            string[] strings = ArrayCreator.Create(3, "Pesho");

            Console.Write(string.Join(" ", integers));
            Console.WriteLine();
            Console.Write(string.Join(" ", strings));
            Console.Write(string.Join(" ", bools));
        }
    }
}
