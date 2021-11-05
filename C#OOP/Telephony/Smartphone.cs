using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public void Browse(string url)
        {
            if (url.Any(u=> Char.IsDigit(u)) == false)
            {
                Console.WriteLine($"Browsing: {url}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }

        public void Call(string number)
        {
            if (number.All(Char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
