using System;


namespace EGNValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int month = 0;
            int year = 0;
            string regionOfBirth = string.Empty;

            while (true)
            {
                Console.WriteLine("Input the day of birth");
                string input = Console.ReadLine();

                try
                {
                    EGNValidator.DayValidation(input);
                    day = int.Parse(input);
                    break;
                }
                catch (Exception em)
                {
                    Console.WriteLine(em.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Input the month of birth");
                string input = Console.ReadLine();

                try
                {
                    EGNValidator.MonthValidation(input);
                    month = int.Parse(input);
                    break;
                }
                catch (Exception em)
                {
                    Console.WriteLine(em.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Input the year of birth");
                string input = Console.ReadLine();

                try
                {
                    EGNValidator.YearValidation(input);
                    year = int.Parse(input);
                    break;
                }
                catch (Exception em)
                {
                    Console.WriteLine(em.Message);
                }
            }

            DateTime dateTime = new DateTime(year, month, day);

            while (true)
            {
                Console.WriteLine("Въведете района");
                regionOfBirth = Console.ReadLine();

                try
                {
                    EGNValidator.RegionValidation(regionOfBirth);
                    break;
                }
                catch (Exception em)
                {
                    Console.WriteLine(em.Message);
                }
            }

            bool isMale = true;

            while (true)
            {
                Console.WriteLine("Input person sex (Male/Female");
                string personSex = Console.ReadLine();

                if (personSex == "Male")
                {
                    break;
                }
                else if (personSex == "Female")
                {
                    isMale = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            string[] EGNS = EGNValidator.GenerateEGNS(dateTime, regionOfBirth, isMale);

            foreach (var EGN in EGNS)
            {
                Console.WriteLine(EGN);
                Console.WriteLine(EGNValidator.isEGNValid(EGN));
            }
        }
    }
}
