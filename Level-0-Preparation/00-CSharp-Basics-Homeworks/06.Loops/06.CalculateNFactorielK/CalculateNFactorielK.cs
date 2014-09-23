/*
 Problem 6.	Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100). 

 */

using System;

class CalculateNFactorielK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        int kFactorial = 1;
        int result = 1;

        if (1 < n && n < 100 && 1 < k && k < n)
        {
            for (int i = n; i >= 1; i--)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }
            result = nFactorial / kFactorial;
            Console.WriteLine("n!/k! = {0}", result.ToString());
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}