
using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharactersRange(start, end);
        }
        static void CharactersRange(char first, char second)
        {
            char start=first;
            char end=second;
            if (first>second)
            {
                start= second;
                end = first;
            }
            for (int i = start+1; i < end; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
