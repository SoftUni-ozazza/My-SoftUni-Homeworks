/*
 Problem 1.	Sum of 3 Integers

Write a program that reads 3 integer numbers from the console and 
prints their sum.

 */

using System;

class SumOf3Integers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        decimal result = a + b + c;

        Console.WriteLine(result);
    }
}