using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            byte counterOFOpeningBraces = 0;
            byte counterOFClosingBraces = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    counterOFOpeningBraces++;

                    if (counterOFOpeningBraces - counterOFClosingBraces > 1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (input == ")")
                {
                    counterOFClosingBraces++;

                    if (counterOFClosingBraces > counterOFOpeningBraces)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (counterOFOpeningBraces == counterOFClosingBraces && counterOFOpeningBraces >= 1)
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
