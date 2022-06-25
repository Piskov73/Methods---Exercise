using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1=int.Parse(Console.ReadLine());
            int numb2=int.Parse(Console.ReadLine());
            PrintFactorialDivision(numb1, numb2);
        }

        private static void PrintFactorialDivision(int numb1, int numb2)
        {

            double factorialNumb1 = FactorialNumb(numb1);
            double factorialNumb2 = FactorialNumb(numb2);
            Console.WriteLine($"{factorialNumb1 / factorialNumb2:f2}");
            
        }

        private static double FactorialNumb(int numb)
        {
            double result = 1.0;
            while (numb>=1)
            {
                result *= numb;
                numb--;
            }
            return result;
        }
    }
}
