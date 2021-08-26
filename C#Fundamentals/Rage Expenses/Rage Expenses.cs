using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLostGames = int.Parse(Console.ReadLine());
            double priceOfHeadset = double.Parse(Console.ReadLine());
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOfKeyboard = double.Parse(Console.ReadLine());
            double priceOfDisplay = double.Parse(Console.ReadLine());
            double rageExpenses = 0;

            if (numberOfLostGames / 2 >= 1)
            {
                rageExpenses += (numberOfLostGames / 2) * priceOfHeadset;
            }

            if (numberOfLostGames / 3 >= 1)
            {
                rageExpenses += (numberOfLostGames / 3) * priceOfMouse;
            }

            if (numberOfLostGames / 6 >= 1)
            {
                rageExpenses += (numberOfLostGames / 6) * priceOfKeyboard;
            }

            if (numberOfLostGames / 6 >= 2)
            {
                rageExpenses += (numberOfLostGames / 12) * priceOfDisplay;
            }

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
