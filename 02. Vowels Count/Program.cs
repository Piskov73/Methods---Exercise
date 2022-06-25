
using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Console.WriteLine(VowelsCount(inputString   ));

        }
        static int VowelsCount(string input)
        {
            //'a','e','i','o','u','y'
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char check = input[i];
                if(check =='a'||check=='e'||check=='i'||
                    check=='o'||check=='u'||check=='y'||
                   check == 'A' || check == 'E' || check == 'I' ||
                   check == 'O' || check == 'U' || check == 'Y')
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
