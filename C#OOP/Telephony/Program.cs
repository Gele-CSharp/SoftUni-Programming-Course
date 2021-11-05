using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> phoneNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> URLs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            StationaryPhone phone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length == 7)
                {
                    phone.Call(phoneNumber);
                }
                else if (phoneNumber.Length == 10)
                {
                    smartphone.Call(phoneNumber);
                }
            }

            foreach (var URL in URLs)
            {
                smartphone.Browse(URL);
            }

        }
    }
}
