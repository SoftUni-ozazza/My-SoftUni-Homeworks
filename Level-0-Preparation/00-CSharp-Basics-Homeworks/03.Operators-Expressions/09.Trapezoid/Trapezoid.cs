/*
 Problem 9.	Trapezoids

Write an expression that calculates trapezoid's area by given 
sides a and b and height h. 

 */

using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid's two sides and height:");
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.Write("h = ");
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}