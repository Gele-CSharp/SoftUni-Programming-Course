using System;
using System.Linq;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            decimal[] array = new decimal[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                decimal sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    switch (input[j])
                    {
                        case 'A':
                        case 'a':
                        case 'E':
                        case 'e':
                        case 'I':
                        case 'i':
                        case 'O':
                        case 'o':
                        case 'U':
                        case 'u':

                            sum += ((int)(input[j]) * input.Length);
                            break;

                        case 'B':
                        case 'b':
                        case 'C':
                        case 'c':
                        case 'D':
                        case 'd':
                        case 'F':
                        case 'f':
                        case 'G':
                        case 'g':
                        case 'H':
                        case 'h':
                        case 'J':
                        case 'j':
                        case 'K':
                        case 'k':
                        case 'L':
                        case 'l':
                        case 'M':
                        case 'm':
                        case 'N':
                        case 'n':
                        case 'P':
                        case 'p':
                        case 'Q':
                        case 'q':
                        case 'R':
                        case 'r':
                        case 'S':
                        case 's':
                        case 'T':
                        case 't':
                        case 'V':
                        case 'v':
                        case 'W':
                        case 'w':
                        case 'X':
                        case 'x':
                        case 'Y':
                        case 'y':
                        case 'Z':
                        case 'z':

                            sum += ((int)(input[j]) / input.Length);
                            break;
                    }
                }

                array[i] = sum;
            }

            foreach (decimal number in array.OrderBy(x=>x))
            {
                Console.WriteLine(number);
            }
        }
    }
}
