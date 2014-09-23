/*
Problem 5.	The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers. 

 */

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        decimal result = Math.Max(Math.Max(a, b), c);
        Console.WriteLine(result);
    }
}