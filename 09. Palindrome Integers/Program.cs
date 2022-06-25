using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                Console.WriteLine(PalingromeInteger(input).ToString().ToLower());
                input = Console.ReadLine();
            }

        }
        static bool PalingromeInteger(string input)
        {
            bool result = true ;
            int n=input.Length/2;
            for (int i = 0; i < n; i++)
            {
                if (input[i]!= input[input.Length - 1 - i])
                {
                    result = false ;
                    return result ;
                }
               
            }
            return result;

        }
        
    }
}
