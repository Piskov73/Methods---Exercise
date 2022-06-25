using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int charactersMin = 6;
            const int charactersMax = 10;
            const int miniDigit = 2;


            string password = Console.ReadLine();

            PasswordValidator(password, charactersMin, charactersMax, miniDigit);
            //if(PasswordValidator(password, charactersMin, charactersMax, miniDigit))
            //{
            //    Console.WriteLine("Password is valid");
            //}
        }

        static void PasswordValidator(string password, int charactersMin, int charactersMax, int miniDigit)
        {
            bool valiidator = true;
            if (!ValidarorPasswordLenght(password, charactersMin, charactersMax))
            {
                Console.WriteLine($"Password must be between {charactersMin} and {charactersMax} characters");
                valiidator = false;
            }
            if (!ValidatorLettersDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                valiidator = false;
            }
            if (!ValidatorMinDigits(password, miniDigit))
            {
                Console.WriteLine($"Password must have at least {miniDigit} digits");
                valiidator = false;
            }
            if (valiidator)
            {
                Console.WriteLine("Password is valid");
            }



        }

        static bool ValidarorPasswordLenght(string password, int charactersMin, int charactersMax)
        {

            if (password.Length >= charactersMin && password.Length <= charactersMax)
            {
                return true;

            }
            return false;

        }
        static bool ValidatorLettersDigits(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }

            }
            return true;
        }
        static bool ValidatorMinDigits(string password, int miniDigit)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitsCount++;

                }
                if (digitsCount >= miniDigit)
                {
                    return true;
                }



            }
            return false;

        }

    }
}
