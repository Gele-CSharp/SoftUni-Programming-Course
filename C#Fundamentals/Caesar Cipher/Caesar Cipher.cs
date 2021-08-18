using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder(); 

            for (int i = 0; i < text.Length; i++)
            {
                int character = Convert.ToInt32(text[i]) + 3;
                encryptedText.Append(Convert.ToChar(character));
            }

            Console.WriteLine(encryptedText.ToString());
        }
    }
}
