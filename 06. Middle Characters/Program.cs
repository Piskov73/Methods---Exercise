using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.	Middle Characters
            string input=Console.ReadLine();
            MiddleCharacters(input);
        }

        private static void MiddleCharacters(string input)
        {
            int control = input.Length;
            if (control % 2 == 0)
            {
                Console.WriteLine($"{input[control/2-1]}{input[control/2]}");
            }
            else
            {
                Console.WriteLine(input[control/2]);
            }
        }
    }
}
