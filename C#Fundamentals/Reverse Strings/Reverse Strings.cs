using System;
using System.Linq;
using System.Text;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();

            //while (text != "end")
            //{
            //    for (int i = text.Length -1; 0 <= i; i--)
            //    {
            //        sb.Append(text[i]);
            //    }

            //    Console.WriteLine($"{text} = {sb.ToString()}");
            //    sb.Clear();

            //    text = Console.ReadLine();
            //}

            while (text != "end")
            {
                char[] reversedText = text.ToCharArray().Reverse().ToArray();
                Console.Write($"{text} = ");
                Console.Write(reversedText);
                Console.WriteLine();

                text = Console.ReadLine();
            }
        }
    }
}
