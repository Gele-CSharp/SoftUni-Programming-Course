using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombNumberAndPower = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bombNumber = bombNumberAndPower[0];
            int power = bombNumberAndPower[1];

            while (numbers.Contains(bombNumber))
            {
                int index = numbers.IndexOf(bombNumber);

                if (index - power >= 0)
                {
                    numbers.RemoveRange(index - power, power);
                }
                else
                {
                    numbers.RemoveRange(0, index);
                }

                index = numbers.IndexOf(bombNumber);

                if (index + power <= numbers.Count - 1)
                {
                    numbers.RemoveRange(index, power + 1);
                }
                else
                {
                    numbers.RemoveRange(index, numbers.Count - index);
                }
            }

            int sum = 0;

            if (numbers.Count > 0)
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
