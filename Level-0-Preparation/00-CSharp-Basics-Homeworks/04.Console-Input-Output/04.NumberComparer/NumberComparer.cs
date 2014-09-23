/*
 Problem 4.	Number Comparer

Write a program that gets two numbers from the console and 
prints the greater of them. Try to implement this without if statements

 */

using System;

class NumberComparer
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());

        decimal result = Math.Max(a, b);

        Console.WriteLine(result);
    }
}