/*
 Problem 6.	The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by 
using only five if statements.

 */

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal e = decimal.Parse(Console.ReadLine());

        if (Math.Max(a,b) > Math.Max(c,d))
        {
            if (Math.Max(a,b) > e)
            {
                Console.WriteLine(Math.Max(a,b));
            }
            else
            {
                Console.WriteLine(e);
            }
        }
        if (Math.Max(a,b) < Math.Max(c,d))
        {
            if (Math.Max(c,d) > e)
            {
                Console.WriteLine(Math.Max(c, d));
            }
            else
            {
                Console.WriteLine(e);
            }
        }
    }
}