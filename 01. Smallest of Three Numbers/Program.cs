using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] threeNumbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                threeNumbers[i] = numb;
            }
            Console.WriteLine(SmallesNumb(threeNumbers ));
        }
        static int SmallesNumb( int[] threeNumbers)
        {
            int minNumb = int.MaxValue;
            for (int i = 0; i < threeNumbers.Length; i++)
            {
                if(threeNumbers[i] < minNumb)
                {
                    minNumb=threeNumbers[i];
                }
            }
            return minNumb;
        }
    }
}
