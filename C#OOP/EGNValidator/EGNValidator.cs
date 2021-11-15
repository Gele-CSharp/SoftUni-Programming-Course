using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGNValidation
{
    public class EGNValidator : IEGNValidator
    {

        public static bool isEGNValid(string egn)
        {
            if (egn == null)
            {
                throw new ArgumentNullException("egn");
            }

            if (egn.All(e => Char.IsDigit(e)) == false)
            {
                return false;
            }

            if (egn.Length != 10)
            {
                return false;
            }

            long EGN = long.Parse(egn);
            
            long montDigits = EGN / 1000000;
            long month = montDigits % 100;


            if (month < 1 || month > 52)
            {
                return false;
            }

            long dayDigits = EGN / 10000;
            long day = dayDigits % 100;

            if (day < 1 || day > 31)
            {
                return false;
            }

            IDigitsWeightGetter digitsWeightGetter = new ValidatorDigitsWeightGetter();
            long controlDigit = long.Parse(GetControlDigit(EGN, digitsWeightGetter));

            if (EGN % 10 != controlDigit)
            {
                return false;
            }

            return true;
        }


        bool IEGNValidator.isEGNValid(string egn)
        {
           return EGNValidator.isEGNValid(egn);
        }


        public static string[] GenerateEGNS(DateTime birthDate, string region, bool isMale)
        {
            int year = int.Parse(birthDate.ToString("yyyy"));
            int month = int.Parse(birthDate.ToString("MM")); ;
            month = year < 1900 ? month += 20 : year > 1999 ? month += 40 : month;
           
            List<string> regionDigitsInfo = GetRegionInfoDigits(region, isMale);
            List<string> EGNS = new List<string>();
            IDigitsWeightGetter digitsWeightGetter = new CreatorDigitsWeightGetter();

            for (int i = 0; i < regionDigitsInfo.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(birthDate.ToString("yy"));
                sb.Append($"{month:d2}".ToString());
                sb.Append(birthDate.ToString("dd"));
                sb.Append(regionDigitsInfo[i]);
                long EGNDigits = long.Parse(sb.ToString());
                string controlDigit = GetControlDigit(EGNDigits, digitsWeightGetter);
                sb.Append(controlDigit);
                EGNS.Add(sb.ToString());
            }

            return EGNS.ToArray();
        }


        string[] IEGNValidator.GenatateEGNS(DateTime birthDate, string region, bool isMale)
        {
            return EGNValidator.GenerateEGNS(birthDate, region, isMale);
        }


        public static bool DayValidation(string input)
        {
            if (int.TryParse(input, out int day) == false)
            {
                throw new InvalidOperationException("Invalid input!");
            }

            if (day < 1 || day > 31)
            {
                throw new ArgumentException("The day must be in the interval [1-31]");
            }

            return true;
        }


        public static bool MonthValidation(string input)
        {
            if (int.TryParse(input, out int month) == false)
            {
                throw new InvalidOperationException("Invalid input!");
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentException("The the month must be in the interval [1-12]");
            }

            return true;
        }


        public static bool YearValidation(string input)
        {
            if (int.TryParse(input, out int year) == false)
            {
                throw new InvalidOperationException("Invalid input!");
            }

            if (year < 1800 || year > 2099)
            {
                throw new ArgumentException("The year must be in the interval [1800-2099]");
            }

            return true;
        }


        public static bool RegionValidation(string region)
        {
            bool isValid = false;

            switch (region)
            {
                case "Благоевград":
                    isValid = true;
                    break;
                case "Бургас":
                    isValid = true;
                    break;
                case "Варна":
                    isValid = true;
                    break;
                case "Велико Търново":
                    isValid = true;
                    break;
                case "Видин ":
                    isValid = true;
                    break;
                case "Враца":
                    isValid = true;
                    break;
                case "Габрово":
                    isValid = true;
                    break;
                case "Кърджали":
                    isValid = true;
                    break;
                case "Кюстендил":
                    isValid = true;
                    break;
                case "Ловеч":
                    isValid = true;
                    break;
                case "Монтана":
                    isValid = true;
                    break;
                case "Пазарджик":
                    isValid = true;
                    break;
                case "Перник":
                    isValid = true;
                    break;
                case "Плевен":
                    isValid = true;
                    break;
                case "Пловдив":
                    isValid = true;
                    break;
                case "Разград ":
                    isValid = true;
                    break;
                case "Русе ":
                    isValid = true;
                    break;
                case "Силистра":
                    isValid = true;
                    break;
                case "Сливен":
                    isValid = true;
                    break;
                case "Смолян ":
                    isValid = true;
                    break;
                case "София - град":
                    isValid = true;
                    break;
                case "София – окръг":
                    isValid = true;
                    break;
                case "Стара Загора":
                    isValid = true;
                    break;
                case "Добрич":
                    isValid = true;
                    break;
                case "Търговище":
                    isValid = true;
                    break;
                case "Хасково":
                    isValid = true;
                    break;
                case "Шумен":
                    isValid = true;
                    break;
                case "Ямбол":
                    isValid = true;
                    break;
                case "Друг":
                    isValid = true;
                    break;
                case "Test":
                    isValid = true;
                    break;
                default:
                    throw new InvalidOperationException("Invalid region!");
            }

            return isValid;
        }


        private static List<string> GetRegionInfoDigits(string region, bool isMale)
        {
            int start = 0;
            int end = 0;

            switch (region)
            {
                case "Благоевград":
                    start = 0;
                    end = 44;
                    break;
                case "Бургас":
                    start = 44;
                    end = 94;
                    break;
                case "Варна":
                    start = 94;
                    end = 140;
                    break;
                case "Велико Търново":
                    start = 140;
                    end = 170;
                    break;
                case "Видин ":
                    start = 170;
                    end = 184;
                    break;
                case "Враца":
                    start = 184;
                    end = 218;
                    break;
                case "Габрово":
                    start = 218;
                    end = 234;
                    break;
                case "Кърджали":
                    start = 234;
                    end = 282;
                    break;
                case "Кюстендил":
                    start = 282;
                    end = 302;
                    break;
                case "Ловеч":
                    start = 302;
                    end = 320;
                    break;
                case "Монтана":
                    start = 320;
                    end = 342;
                    break;
                case "Пазарджик":
                    start = 342;
                    end = 378;
                    break;
                case "Перник":
                    start = 378;
                    end = 396;
                    break;
                case "Плевен":
                    start = 396;
                    end = 436;
                    break;
                case "Пловдив":
                    start = 436;
                    end = 502;
                    break;
                case "Разград ":
                    start = 502;
                    end = 528;
                    break;
                case "Русе ":
                    start = 528;
                    end = 556;
                    break;
                case "Силистра":
                    start = 556;
                    end = 576;
                    break;
                case "Сливен":
                    start = 576;
                    end = 602;
                    break;
                case "Смолян ":
                    start = 602;
                    end = 624;
                    break;
                case "София – град":
                    start = 624;
                    end = 722;
                    break;
                case "София – окръг":
                    start = 722;
                    end = 752;
                    break;
                case "Стара Загора":
                    start = 752;
                    end = 790;
                    break;
                case "Добрич":
                    start = 790;
                    end = 822;
                    break;
                case "Търговище":
                    start = 822;
                    end = 844;
                    break;
                case "Хасково":
                    start = 844;
                    end = 872;
                    break;
                case "Шумен":
                    start = 872;
                    end = 904;
                    break;
                case "Ямбол":
                    start = 904;
                    end = 926;
                    break;
                case "Друг":
                    start = 926;
                    end = 999;
                    break;
                default:
                    throw new InvalidOperationException("Invalid input!");
                    
            }

            List<string> allRegionInfoDigits = new List<string>();

            for (int i = start; i < end; i++)
            {
                string digits = $"{i:d3}".ToString();

                if (isMale && i % 2 == 0)
                {
                    allRegionInfoDigits.Add(digits);
                }
                else if (isMale == false && i % 2 != 0)
                {
                    allRegionInfoDigits.Add(digits);
                }
            }
            
            return allRegionInfoDigits;
        }


        private static string GetControlDigit(long EGN, IDigitsWeightGetter digitsWeightGetter)
        {
            long digitsWeightSum = digitsWeightGetter.SumDigitsWeight(EGN);

            long subResult = digitsWeightSum / 11;
            long result = digitsWeightSum - subResult * 11;

            if (result >= 10)
            {
                return "0";
            }
            else
            {
                return result.ToString();
            }
        }
    }
}
