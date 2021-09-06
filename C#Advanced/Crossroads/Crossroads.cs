using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int durationOfFreeWindow = int.Parse(Console.ReadLine());
            int totalDuration = durationOfGreenLight + durationOfFreeWindow;
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int numberOfPassedCars = 0;

            while (command.ToUpper() != "END")
            {
                if (command == "green")
                {
                    totalDuration = durationOfGreenLight + durationOfFreeWindow;

                    while (cars.Count > 0)
                    {
                        string car = string.Empty;

                        if (cars.TryPeek(out car))
                        {
                            if (totalDuration - cars.Peek().Length >= 0 && totalDuration > durationOfFreeWindow)
                            {
                                totalDuration -= cars.Dequeue().Length;
                                numberOfPassedCars++;
                            }
                            else 
                            {
                                int index = cars.Peek().Length + (totalDuration - cars.Peek().Length);
                                char hitChar = char.Parse(car.Substring(index, 1));
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {hitChar}.");
                                return;
                            }
                            
                            if (totalDuration <= durationOfFreeWindow && cars.Count > 0)
                            {
                                cars.Clear();
                            }
                        }
                    }
                }
                else
                {
                    string car = command;
                    cars.Enqueue(car);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{numberOfPassedCars} total cars passed the crossroads.");
        }
    }
}
