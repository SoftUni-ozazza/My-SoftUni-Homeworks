/*
 Problem 17.	* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) 
of given two integers a and b. Use the Euclidean algorithm 
(find it in Internet). 

 */

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int c;

            c = b;
            b = a % b;
            a = c;
        }
        Console.WriteLine("GCD(a, b) = {0}", a);
    }
}