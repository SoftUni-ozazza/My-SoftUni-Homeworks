/*
 Problem 7.	Point in a Circle

Write an expression that checks if given 
point (x,  y) is inside a circle K({0, 0}, 2). 

 */

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Point x:");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Point y:");
        decimal y = decimal.Parse(Console.ReadLine());

        decimal r = 2;

        // By basic equation of a circle:
        bool inCircle = (x*x) + (y*y) <= r*r;

        if (inCircle)
        {
            Console.WriteLine(inCircle + " The point ({0}, {1}) is within the circle", x, y);
        }
        else
        {
            Console.WriteLine(inCircle + " The point ({0}, {1}) is out of the circle", x, y);
        }
    }
}