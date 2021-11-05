using System;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public void Call(string number)
        {
            if (number.All(Char.IsDigit))
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
