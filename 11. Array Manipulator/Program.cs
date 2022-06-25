using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (comand[0] != "end")
            {

            

                if (comand[0] == "exchange")
                {
                    if (int.Parse(comand[1]) < 0 || int.Parse(comand[1]) >= inputArray.Length)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {

                        inputArray = ExchangeArray(inputArray, int.Parse(comand[1]));
                        //Console.WriteLine(String.Join(' ', inputArray));
                    }
                }
               
                else if (comand[0] == "max" || comand[0] == "min")
                {
                    MaxMinEvevOdd(inputArray, comand[0], comand[1]);
                }
                else if (comand[0] == "first" || comand[0] == "last")
                {
                    FirstLastEvenOdd(inputArray, comand);
                }
              

                comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }
        static void MaxMinEvevOdd(int[]inpit,string maxMin, string evanOdd)
        {
            int result = -1;
            int max = int.MinValue;
            int min = int.MaxValue;
            if (maxMin == "max")
            {
                if(evanOdd == "even")
                {
                    for (int i = 0; i < inpit.Length; i++)
                    {
                        if (inpit[i] >= max&&inpit[i]%2==0)
                        {
                            max = inpit[i];
                            result = i;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < inpit.Length; i++)
                    {
                        if (inpit[i] >= max && inpit[i] % 2 != 0)
                        {
                            max = inpit[i];
                            result = i;
                        }
                    }
                }
                        
            }
            else
            {
                if (evanOdd == "even")
                {
                    for (int i = 0; i < inpit.Length; i++)
                    {
                        if (inpit[i] <= min && inpit[i] % 2 == 0)
                        {
                            min = inpit[i];
                            result = i;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < inpit.Length; i++)
                    {
                        if (inpit[i] <= min && inpit[i] % 2 != 0)
                        {
                            min = inpit[i];
                            result = i;
                        }
                    }
                }
            }
            if (result == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(  result);
            }
        }
      
        static int[] ExchangeArray(int[] input, int index)
        {
            int[] exchangeArray = new int[input.Length];
            int count = 0;

            for (int i = index + 1; i < exchangeArray.Length; i++)
            {
                exchangeArray[count] = input[i];
                count++;
            }
            for (int i = 0; i <= index; i++)
            {
                exchangeArray[count] = input[i];
                count++;
            }
            return exchangeArray;
        }

        static void FirstLastEvenOdd(int[] input, string [] comand)
        {
            //first {count} even/odd 
            //last {count} even/odd 
            string firstLast = comand[0];
            string evenOdd = comand[2];
            int count = int.Parse(comand[1]);
            List<int> output = new List<int>();
            if (count >input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
           

            if (firstLast == "first")
            {
                int index = 0;
                if (evenOdd == "even")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            index++;
                            if(index<=count)
                            {
                                output.Add(input[i]);
                            }
                            else
                            {
                                break;
                            }
                           
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            index++;
                            if (index <= count)
                            {
                                output.Add(input[i]);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }
            }
            else
            {
                int index = 0;
                if (evenOdd == "even")
                {
                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        if (input[i] % 2 == 0)
                        {
                            index++;
                            if (index <= count)
                            {
                                output.Add(input[i]);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }
                else
                {
                    for (int i = input.Length-1; i >= 0; i--)
                    {
                        if (input[i] % 2 != 0)
                        {
                            index++;
                            if (index <= count)
                            {
                                output.Add(input[i]);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ",output)}]");
        }
    }
}
