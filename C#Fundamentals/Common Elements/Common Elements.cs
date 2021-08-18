using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split().ToArray();
            string[] secondString = Console.ReadLine().Split().ToArray();
            
            for (int i = 0; i < secondString.Length; i++)
            {
                for (int j = 0; j < firstString.Length; j++)
                {
                    if (firstString[j] == secondString[i])
                    {
                        Console.Write($"{firstString[j]} ");
                    }
                }
            }
        }
    }
}
