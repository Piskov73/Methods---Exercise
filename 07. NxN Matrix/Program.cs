

using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            PrintMatrix(numb);
        }

        private static void PrintMatrix(int numb)
        {
            for (int rows = 0; rows < numb; rows++)
            {
                for (int column = 0; column < numb; column++)
                {
                    Console.Write($"{numb} ");
                }
                Console.WriteLine();
            }
        }
    }
}
