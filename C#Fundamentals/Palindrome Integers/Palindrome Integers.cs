using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                IsPalindrome(number);
                number = Console.ReadLine();
            }
        }

        public static void IsPalindrome(string number)
        {
            string reversedNumber = string.Empty;

            for (int i = number.Length - 1; 0 <= i; i--)
            {
                reversedNumber += number[i];
            }

            if (number == reversedNumber)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
