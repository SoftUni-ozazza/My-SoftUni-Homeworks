/*
 Problem 7.	Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them 
sorted in descending order. Use nested if statements.
Don’t use arrays and the built-in sorting functionality. 

 */

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        if (a > b)
        {
            if ((a > c) && (b > c))
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            if ((a > c) && (b < c))
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            if (a < c)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        if (b > a)
        {
            if ((b > c) && (a > c))
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            if ((b > c) && (a < c))
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            if (b < c)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
        if (a == b)
        {
            if ((a == c) || (a > c))
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            if (a < c)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
        if (b == c)
        {
            if (b > a)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            if (b < a)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
        }
        if (a == c)
        {
            if (a > b)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            if (a < b)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
        }
    }
}