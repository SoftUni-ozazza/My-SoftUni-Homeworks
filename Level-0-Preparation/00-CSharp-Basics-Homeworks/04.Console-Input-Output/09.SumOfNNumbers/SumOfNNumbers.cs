/*
Problem 9.	Sum of n Numbers

Write a program that enters a number n and 
after that enters more n numbers and calculates and 
prints their sum. Note that you may need to use a for-loop. 

 */

using System;

class SumOfNNumbers
{
    static void Main()
    {
        int timesEntered = int.Parse(Console.ReadLine());
        decimal sum = 0;

        for (int i = 0; i < timesEntered; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}