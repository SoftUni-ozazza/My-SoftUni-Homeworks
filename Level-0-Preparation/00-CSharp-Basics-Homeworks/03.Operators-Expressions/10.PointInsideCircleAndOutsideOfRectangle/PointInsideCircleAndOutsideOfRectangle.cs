/*
 Problem 10.	Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for 
given point (x, y) if it is 
within the circle K({1, 1}, 1.5) and 
out of the rectangle R(top=1, left=-1, width=6, height=2). 

 */

using System;

class PointInsideCircleAndOutsideOfRectangle
{
    static void Main()
    {
        Console.Write("Enter x = ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("y = ");
        decimal y = decimal.Parse(Console.ReadLine());

        // circle
        decimal a = 1m;
        decimal b = 1m;
        decimal r = 1.5m;

        // using from math an equation of circle (x-a)^2 + (y-b)^2 = r^2; 
        // or x^2 + y^2 – 2ax – 2by + a^2 + b^2 – r^2 <= 0
        decimal circle = (x * x) + (y * y) - (2 * a * x) - (2 * b * y) + (a * a) + (b * b) - (r * r);
        bool insideCircle = circle <= 0;

        // rectangle
        decimal top = 1m;
        decimal left = -1m;
        decimal width = 6m;
        decimal height = 2m;

        decimal minRx = left;
        decimal maxRx = left + width;

        decimal minRy = top - height;
        decimal maxRy = top;

        bool insideRectangle = (x <= maxRx) && (x >= minRx) &&
                                (y <= maxRy) && (y >= minRy);

        bool outsideRectangle = !insideRectangle;

        // both
        bool trueValidation = insideCircle && outsideRectangle;
        if (trueValidation)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}