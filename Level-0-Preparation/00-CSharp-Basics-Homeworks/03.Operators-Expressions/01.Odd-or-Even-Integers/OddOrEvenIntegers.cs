/*
 Problem 1.	Odd or Even Integers

Write an expression that checks if given integer is odd or even. 

 */

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}
