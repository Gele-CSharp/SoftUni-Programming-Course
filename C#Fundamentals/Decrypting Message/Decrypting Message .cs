using System;
using System.Text;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            StringBuilder message = new StringBuilder();

            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                message.Append((char)(letter + key));
            }

            Console.WriteLine(message);
        }
    }
}
