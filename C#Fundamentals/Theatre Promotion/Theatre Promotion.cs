using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string price = string.Empty;

            switch (day)
            {
                case "Weekday":

                    if ( 0 <= age && age <= 18)
                    {
                        price += "12$";
                    }
                    else if (18 <= age && age <= 64)
                    {
                        price += "18$";
                    }
                    else if (64 <= age && age <= 122)
                    {
                        price += "12$";
                    }
                    else
                    {
                        price = "Error!";
                    }
                    break;

                case "Weekend":

                    if (0 <= age && age <= 18)
                    {
                        price += "15$";
                    }
                    else if (18 <= age && age <= 64)
                    {
                        price += "20$";
                    }
                    else if (64 <= age && age <= 122)
                    {
                        price += "15$";
                    }
                    else
                    {
                        price = "Error!";
                    }
                    break;

                case "Holiday":

                    if (0 <= age && age <= 18)
                    {
                        price += "5$";
                    }
                    else if (18 <= age && age <= 64)
                    {
                        price += "12$";
                    }
                    else if (64 <= age && age <= 122)
                    {
                        price += "10$";
                    }
                    else
                    {
                        price = "Error!";
                    }
                    break;

                default: price = "Error!";
                    break;
            }

            Console.WriteLine(price);
        }
    }
}
