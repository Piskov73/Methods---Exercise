
using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            PrintTopNumber(numb);
        }

        private static void PrintTopNumber(int numb)
        {
            for (int i = 1; i <= numb; i++)
            {
                if (SumDivisible8(i) && LastOddDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool SumDivisible8(int number)
        {
            int sum=0;
            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
        static bool LastOddDigits(int number)
        {
           int a=0;
            while (number > 0)
            {
                a = number % 10;
                number /= 10;
                if (a % 2 != 0)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
