using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }

        public static void ValidatePassword(string password)
        {
            int numberOfDigits = 0;
            bool IsOtherCharacter = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    numberOfDigits++;
                }

                if (Char.IsDigit(password[i]) == false && Char.IsLetter(password[i]) == false)
                {
                    IsOtherCharacter = true;
                }
            }

            if ((password.Length >= 6 && password.Length <= 10) && IsOtherCharacter == false && numberOfDigits >= 2)
            {
                Console.WriteLine("Password is valid");
                return;
            }

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (IsOtherCharacter)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (numberOfDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
