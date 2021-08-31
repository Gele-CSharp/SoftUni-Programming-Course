using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            switch (typeOfGroup)
            {
                case "Students":

                    if (dayOfWeek == "Friday")
                    {
                        price += numberOfPeople * 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price += numberOfPeople * 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price += numberOfPeople * 10.46;
                    }

                    if (numberOfPeople >= 30)
                    {
                        price -= price * 0.15;
                    }

                    break;

                case "Business":

                    if (numberOfPeople >= 100)
                    {
                        numberOfPeople -= 10;
                    }

                    if (dayOfWeek == "Friday")
                    {
                        price += numberOfPeople * 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price += numberOfPeople * 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price += numberOfPeople * 16;
                    }

                    break;

                case "Regular":

                    if (dayOfWeek == "Friday")
                    {
                        price += numberOfPeople * 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price += numberOfPeople * 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price += numberOfPeople * 22.50;
                    }

                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        price -= price * 0.05;
                    }

                    break;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
