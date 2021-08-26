using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string stringToReplace = string.Empty;

            for (int i = 0; i < text.Length - 1; i++)
            {
                char letter = text[i];

                if (letter == text[i+1])
                {
                    stringToReplace += letter;

                    if (i == text.Length - 2)
                    {
                        stringToReplace += letter;
                        text = text.Replace(stringToReplace, letter.ToString());
                        break;
                    }
                }
                else
                {
                    if (stringToReplace.Length > 0)
                    {
                        stringToReplace += letter;
                        text = text.Replace(stringToReplace, letter.ToString());
                        stringToReplace = string.Empty;
                        i = - 1;
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}
