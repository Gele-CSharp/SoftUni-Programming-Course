using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintCountOfVowels(text);
        }

        public static void PrintCountOfVowels(string text)
        {
            int countOfVowels = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
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
                    case 'Y':
                    case 'y':

                        countOfVowels++;
                        break;
                }
            }

            Console.WriteLine(countOfVowels);
        }
    }
}
