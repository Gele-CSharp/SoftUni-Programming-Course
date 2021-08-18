using System;
using System.Text;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Console.ReadLine());
            sb.Append(Console.ReadLine());
            sb.Append(Console.ReadLine());

            Console.WriteLine(sb);
        }
    }
}
