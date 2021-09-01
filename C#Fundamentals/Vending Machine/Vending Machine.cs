using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumOfCoins = 0;
            double price = 0;
            bool IsProductValid = true;

            while (input != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.10 || coin == 0.20 || coin == 0.50 || coin == 1 || coin == 2)
                {
                    sumOfCoins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.70;
                        break;
                    case "Crisps":
                        price = 1.50;
                        break;
                    case "Soda":
                        price = 0.80;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        IsProductValid = false;
                        break;
                }

                if (sumOfCoins >= price && IsProductValid)
                {
                    sumOfCoins -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (IsProductValid)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }

            if (sumOfCoins >= 0)
            {
                Console.WriteLine($"Change: {sumOfCoins:f2}");
            }
        }
    }
}
