using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "Delete")
                {
                    int number = int.Parse(input[1]);
                    listOfIntegers.RemoveAll(x=>x == number);
                }
                else if (input[0] == "Insert")
                {
                    int number = int.Parse(input[1]);
                    int position = int.Parse(input[2]);

                    listOfIntegers.Insert(position, number);
                }
                
                input = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}
