/*
 Problem 3.	Circle Perimeter and Area
 
Write a program that reads the radius r of a circle and prints its 
    perimeter and area formatted with 
    2 digits after the decimal point. 

 */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        decimal r = decimal.Parse(Console.ReadLine());

        decimal p = (decimal)Math.PI * r * 2;
        decimal s = (decimal)Math.PI * r * r;

        Console.WriteLine("r = {0}, p = {1:F2}, s = {2:F2}", r, p, s);
    }
}