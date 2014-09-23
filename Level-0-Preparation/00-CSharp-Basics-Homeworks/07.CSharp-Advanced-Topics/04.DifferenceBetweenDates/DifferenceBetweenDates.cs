/*
 Problem 4.	Difference between Dates

Write a program that enters two dates in format dd.MM.yyyy 
and returns the number of days between them. 

 */

using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter date (dd.MM.yyyy): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        TimeSpan result = secondDate - firstDate;
        Console.WriteLine("{0}", result.Days);
    }
}