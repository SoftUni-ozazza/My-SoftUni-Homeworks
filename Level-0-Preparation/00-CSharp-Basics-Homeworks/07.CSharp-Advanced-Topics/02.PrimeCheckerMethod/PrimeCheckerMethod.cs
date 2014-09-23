/*
Problem 2.	Prime Checker

Write a Boolean method IsPrime(n) that check whether
a given integer number n is prime. 

 */

using System;

class PrimeCheckerMethod
{
    static void Main()
    {
        Console.Write("number = ");
        long number = long.Parse(Console.ReadLine());

        CalculateAndPrintIsPrime(number);
    }

    static void CalculateAndPrintIsPrime(long n)
    {
        long divider = 2;
        long maxDivider = (long)Math.Sqrt(n);
        bool isPrime = true;

        if (n == 0 || n == 1)
        {
            isPrime = false;
        }
        else
        {
            while (isPrime && (divider <= maxDivider))
            {
                if (n % divider == 0)
                {
                    isPrime = false;
                }
                divider++;
            }
        }
        Console.WriteLine("Is it a prime? {0}", isPrime);
    }
}