using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rotatedArray = new int[array.Length];
            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    rotatedArray[j] = array[j + 1];
                    rotatedArray[rotatedArray.Length - 1] = array[0];
                }

                for (int j = 0; j < array.Length; j++)
                {
                    array[j] = rotatedArray[j];
                }
            }

            if (numberOfRotations > 0)
            {
                Console.Write(string.Join(" ", rotatedArray));
            }
            else
            {
                Console.Write(string.Join(" ", array));
            }
        }
    }
}
