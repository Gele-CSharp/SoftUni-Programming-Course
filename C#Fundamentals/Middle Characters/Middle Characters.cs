using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleCharacter(text);
        }

        public static void PrintMiddleCharacter(string text)
        {
            string middleCharacter = string.Empty;

            if (text.Length % 2 != 0)
            {
                middleCharacter = text[(text.Length / 2)].ToString();
            }
            else
            {
                middleCharacter = text[(text.Length / 2) - 1].ToString() + text[(text.Length / 2)].ToString();
            }

            Console.WriteLine(middleCharacter);
        }
    }
}
