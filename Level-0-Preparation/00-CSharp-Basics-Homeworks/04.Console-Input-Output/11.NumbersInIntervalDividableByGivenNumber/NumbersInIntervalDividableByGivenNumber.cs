/*
 Problem 11.	* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and 
prints how many numbers p exist between them such that 
the reminder of the division by 5 is 0. 

 */

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = first; i <= second; i++)
        {
            if (i % 5 == 0)
            {
                //Console.WriteLine(i);
                p++;
            }
        }
        Console.WriteLine("p = " + p);
    }
}