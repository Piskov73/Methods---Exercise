using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add and Subtract
            int numb1 = int.Parse(Console.ReadLine());
            int numb2 = int.Parse(Console.ReadLine());
            int numb3 = int.Parse(Console.ReadLine());
            int resultAdd = ADD(numb1, numb2);

            Subtract(resultAdd, numb3);

        }

        private static void Subtract(int resultAdd, int numb3)
        {
            Console.WriteLine(resultAdd-numb3);
        }

        private static int ADD(int numb1, int numb2)
        {
            return numb1 + numb2;
        }

    }
}
