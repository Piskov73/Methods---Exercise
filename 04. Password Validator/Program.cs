using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int charactersMin = 6;
            const int charactersMax = 10;
            const int digits = 2;

            string pasword = Console.ReadLine();
            PasswordValidator(pasword, charactersMin, charactersMax, digits);

        }
        //  It should contain 6 – 10 characters(inclusive)
        //•	It should contain only letters and digits
        //•	It should contain at least 2 digits
        static void PasswordValidator(string password, int charactersMin, int charactersMax, int digits)
        {
            bool validator = true;
            if (!ValidatorLength(password, charactersMin, charactersMax))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                validator = false;
            }
            if (!lettersAndDigits(password))
            {
                Console.WriteLine(	"Password must consist only of letters and digits");
                validator = false;
            }
            if (!Digits(password, digits))
            {
                Console.WriteLine(	"Password must have at least 2 digits");
                validator=false;
            }



            if (validator)
            {
                Console.WriteLine("Password is valid");
            }




        }
        static bool ValidatorLength(string password, int charactersMin, int charactersMax)
        {
            if (password.Length >= charactersMin && password.Length <= charactersMax)
            {
                return true;
            }
            return false;
        }
        //if (!char.IsLetterOrDigit(ch))
        //       {
        //           return false;
        //       }
        static bool lettersAndDigits(string password)
        {
            foreach (var ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true; ;
        }
        static bool Digits(string password, int digits)
        {
            int cont = 0;
            foreach (var ch in password)
            {
                if (char.IsDigit(ch))
                {
                    cont++;
                }
                if(cont == digits)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
