/*
 Problem 7.	Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose 
k different members out of a group of n different elements 
(also known as the number of combinations) 
 *  
For example, there are 2598960 ways to withdraw 5 cards 
out of a standard deck of 52 cards. Your task is 
to write a program that calculates n! / (k! * (n-k)!) for 
given n and k (1 < k < n < 100). Try to use only two loops.


 */


using System;
using System.Numerics;

class CalculateFactorialNK
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFact = 1;

        if (1 < n && n < 100 && 1 < k && k < n)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i <= n - k)
                {
                    nMinusKFact *= i;
                }
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }
            BigInteger result = nFactorial / (kFactorial * nMinusKFact);
            Console.WriteLine("result = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}