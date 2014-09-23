/*
 Problem 13.	* Comparing Floats
Write a program that safely compares floating-point numbers 
        (double) with precision eps = 0.000001. 
 Note that we cannot directly compare two floating-point numbers        
        a and b 
 by a==b because of the nature of the floating-point arithmetic.
 
 Therefore, we assume two numbers are equal if they are 
 more closely to each other than a fixed constant eps. 
 Examples:
 
Number a	Number b	    Equal       Explanation
                        (with precision 
 *                       eps=0.000001)	
5.3	        6.01	        false	    The difference of 0.71 is 
                                        too big (> eps)
5.00000001	5.00000003	    true	    The difference 0.00000002 < eps
5.00000005	5.00000001	    true	    The difference 0.00000004 < eps
-0.0000007	0.00000007	    true	    The difference 0.00000077 < eps
-4.999999	-4.999998	    false	    Border case. 
                                        The difference 0.000001 == eps. 
                                        We consider the numbers are different.
4.999999	4.999998	    false	    Border case. 
                                        The difference 0.000001 == eps. 
                                        We consider the numbers are different.

 */

using System;

class ComparingFoats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        bool equalByEps = a * eps == b * eps; 
        bool equaltoFloat = (float)a == (float)b;
        bool equalDecimal = (decimal)a == (decimal)b;
        bool equalByMath = Math.Abs(a - b) < eps;

        Console.WriteLine();
        Console.WriteLine("Equal by eps = 0.000001: {1}", eps, equalByEps);
        Console.WriteLine("Floats equality: {0}", equaltoFloat);
        Console.WriteLine("Decimal equality: {0}", equalDecimal);
        Console.WriteLine("Equal by Math.Abs() = {0}", equalByMath);
        Console.WriteLine();
    }
}