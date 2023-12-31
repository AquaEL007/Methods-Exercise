﻿/*
5
2
 */

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            FactorialsDevidedBy(first, second);
        }

        private static void FactorialsDevidedBy(int first, int second)
        {
            double firstFactorial = 1;

            for (int i = 1; i <= first; i++)
            {
                firstFactorial = firstFactorial * i;
            }

            double secondFactorial = 1;
            for (int i = 1; i <= second; i++)
            {
                secondFactorial *= i;
            }           
            Console.WriteLine($"{(firstFactorial / secondFactorial):F2}");
        }
    }
}