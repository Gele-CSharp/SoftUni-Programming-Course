using System;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string foodInfoPattern = @"([#|]{1})([a-zA-Z\s]+)\1([0-9]{2}/[0-9]{2}/[0-9]{2})\1([0-9]+)\1";
            int totalCalories = 0;

            MatchCollection foodMatches = Regex.Matches(text, foodInfoPattern);

            foreach (Match food in foodMatches)
            {
                totalCalories += int.Parse(food.Groups[4].Value);
            }

            int numberOfDays = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {numberOfDays} days!");

            foreach (Match food in foodMatches)
            {
                Console.WriteLine($"Item: {food.Groups[2].Value}, Best before: {food.Groups[3].Value}, Nutrition: {food.Groups[4].Value}");
            }
        }
    }
}
