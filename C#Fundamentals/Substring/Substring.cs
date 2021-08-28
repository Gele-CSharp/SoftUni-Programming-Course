using System;

namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine();
            //int index = 0;

            //while (index != -1)
            //{
            //    index = text.IndexOf(stringToRemove);
            //    text = text.Remove(index, stringToRemove.Length);
            //    index = text.IndexOf(stringToRemove);
            //}

            //Console.WriteLine(text);

            while (text.Contains(stringToRemove))
            {
                text = text.Replace(stringToRemove, "");
            }

            Console.WriteLine(text);
        }
    }
}
