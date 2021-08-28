using System;
using System.Text;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int explosionPower = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentCharacter = text[i];

                if (currentCharacter == '>')
                {
                    explosionPower += Convert.ToInt32(text[i + 1]) - 48;
                    result.Append(currentCharacter.ToString());
                    continue;
                }
                else if (explosionPower == 0)
                {
                    result.Append(currentCharacter.ToString());
                }

                if (explosionPower > 0)
                {
                    explosionPower--;
                }
            }

            Console.WriteLine(result);
        }
    }
}
