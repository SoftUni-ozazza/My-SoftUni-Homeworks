/*
Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

Write a program that, for a given two integer numbers n and x,
calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
Use only one loop. Print the result with 5 digits after the decimal point.
*/

using System;

class CalculateFactoriel
{
    static void Main()
    {
        Console.Write("n = ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.Write("x = ");
        decimal x = decimal.Parse(Console.ReadLine());
        
        // n!
        decimal nResult = 1;
        decimal xResult = 1;
        decimal sum = 1;

        for (int i = 1; i <= n; i++)
        {
            nResult *= i;
            xResult *= x;
            sum += (nResult / xResult);
        }
        Console.WriteLine("S = {0:F5}", sum);
    }
}