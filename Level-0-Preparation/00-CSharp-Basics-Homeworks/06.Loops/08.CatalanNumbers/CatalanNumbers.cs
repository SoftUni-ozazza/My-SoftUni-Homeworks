/*
 Problem 8.	Catalan Numbers

In combinatorics, the Catalan numbers.  
Write a program to calculate the nth Catalan number by given n (1 < n < 100). 

 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial2N = 1;
        BigInteger nPlus1Factorial = 1;
        BigInteger nFactorial = 1;
        BigInteger nCatalan = 0;

        if (n == 1)
        {
            nCatalan = 1;
        }
        if (n > 1 && n < 100)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial2N *= i;

                if (i <= n + 1)
                {
                    nPlus1Factorial *= i;
                }
                if (i <= n)
                {
                    nFactorial *= i;
                }
            }
        }
        nCatalan = factorial2N / (nPlus1Factorial * nFactorial);
        Console.WriteLine(nCatalan);
    }
}