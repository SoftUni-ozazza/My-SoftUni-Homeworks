/*
 Problem 4.	Rectangles
 
Write an expression that calculates rectangle’s 
perimeter and area by given width and height. 
 
* Examples:
width	height	perimeter	area
3	    4	    14	        12
2.5	    3	    11	        7.5
5	    5	    20	        25

*/

using System;

class Program
{
    static void Main()
    {
        decimal width = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());

        decimal perimeter = 2 * (width + height);
        decimal area = width * height;

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}
