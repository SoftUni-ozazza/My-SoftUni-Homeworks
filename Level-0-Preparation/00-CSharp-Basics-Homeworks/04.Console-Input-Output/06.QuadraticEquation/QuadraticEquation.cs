/* 
 Problem 6.	Quadratic Equation
 
 Write a program that reads the coefficients 
        a, b and c 
 of a quadratic equation 
        ax2 + bx + c = 0 and 
 solves it (prints its real roots).
*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("This program solves quadratic equations. \nEnter: a = ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.Write("c = ");
        decimal c = decimal.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("({0})*x^2 + ({1})*x + ({2}) = 0", a, b, c);
        Console.WriteLine();

        decimal d = (b * b) - 4 * a * c;
        decimal x1;
        decimal x2;

        // The following code describes most of the cases:
        if ((a != 0) && (b != 0) && (c != 0))
        {
            if (d > 0)
            {
                Console.WriteLine("x1 != x2,");
                Console.WriteLine("x1 and x2 are real numbers");

                x1 = (-b - (decimal)Math.Sqrt((double)d)) / (2 * a);
                x2 = (-b + (decimal)Math.Sqrt((double)d)) / (2 * a);

                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (d == 0)
            {
                Console.WriteLine("x1 = x2");
                Console.WriteLine("real numbers");

                x1 = -(b) / (2 * a);
                x2 = x1;

                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else if (d < 0)
            {
                Console.WriteLine("x1 and x2 are not real numbers");
                Console.WriteLine("x1 and x2 are complex numbers and they belongs to C");
            }

            // This is for other times!
            /*
            
            double k;
            double i;

            else if ((d >= 0) && ((b == 2 * k) || (b == 2 * i)))
            {
                x1 = (-(k) - Math.Sqrt((k * k) - (a * c) / a));
                x2 = (-(k) + Math.Sqrt((k * k) - (a * c) / a));

                Console.WriteLine("x1 = {0} \nx2 = {1}", x1, x2);
            }
            
            */
        }
        else if ((a != 0) && (b != 0) && (c == 0))
        {
            x1 = 0;
            x2 = -(b / a);

            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
        else if ((a != 0) && (b == 0) && (c != 0))
        {
            if (-(c / a) > 0)
            {
                Console.WriteLine("x1 and x2 are within R");

                x1 = (decimal)(+(Math.Sqrt((double)(-(c / a)))));
                x2 = (decimal)(-(Math.Sqrt((double)(-(c / a)))));

                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (-(c / a) < 0)
            {
                Console.WriteLine("x1 and x2 belongs to C");
            }
        }
        else if ((a != 0) && (b == 0) && (c == 0))
        {
            x1 = 0;
            x2 = x1;

            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else if (a == 0)
        {
            Console.WriteLine("Enter an quadratic equation!");
        }
    }
}