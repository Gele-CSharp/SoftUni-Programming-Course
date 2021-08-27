using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%([A-Z]{1}[a-z]+)%(?:[A-z]+)*<(\w+)>(?:[A-z]+)*\|([0-9]+)\|(?:[A-z]+)*([0-9]+\.{0,1}[0-9]{0,})\$";
            double totalIncome = 0; 

            while (input != "end of shift")
            {
                Match order = Regex.Match(input, pattern);

                if (order.Success)
                {
                    string customerName = order.Groups[1].Value;
                    string product = order.Groups[2].Value;
                    int quantity = int.Parse(order.Groups[3].Value);
                    double price = double.Parse(order.Groups[4].Value);
                    double totalPrice = quantity * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
