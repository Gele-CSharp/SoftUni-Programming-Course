using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] newArray = new int[array.Length / 2];

            for (int i = 0; i < array.Length / 4; i++)
            {
                newArray[i] = array[(array.Length / 4) + i] 
                            + array[((array.Length / 4) - 1) - i];

                newArray[newArray.Length - 1 - i] = array[((array.Length - 1) - array.Length / 4) - i] 
                                                  + array[array.Length - (array.Length / 4) + i];  
            }

            Console.Write(string.Join(" ", newArray));
            Console.WriteLine();
        }
    }
}
