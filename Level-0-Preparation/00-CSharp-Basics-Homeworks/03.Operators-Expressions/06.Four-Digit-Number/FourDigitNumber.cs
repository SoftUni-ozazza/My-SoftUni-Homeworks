/*
 Problem 6.	Four-Digit Number
Write a program that takes as 
    input a four-digit number in format abcd (e.g. 2011) and 
performs the following:
    Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. 
    Examples:

n	    sum of digits	reversed	last digit in front	    second and 
                                                            third digits exchanged
2011	4	            1102	    1201	                2101
3333	12	            3333	    3333	                3333
9876	30	            6789	    6987	                9786

 */

using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        
        int a = (number/ 1000) % 10;
        int b = (number/ 100) % 10;
        int c = (number/ 10) % 10;
        int d = number % 10;
        
        Console.WriteLine(a + b + c + d);
        Console.Write(d);
        Console.Write(c);
        Console.Write(b);
        Console.Write(a);
        Console.WriteLine();
        Console.Write(d);
        Console.Write(a);
        Console.Write(b);
        Console.Write(c);
        Console.WriteLine();
        Console.Write(a);
        Console.Write(c);
        Console.Write(b);
        Console.Write(d);
        Console.WriteLine();

        //  int input = 4;
        //  int[] numberArray = new int[input];
        //  int number = int.Parse(Console.ReadLine());
        //  
        //  int p = 10;
        //  int counter = 1;
        //  for (int i = numberArray.Length - 1; i >= 0; i--)
        //  {
        //      numberArray[i] = (number / counter) % p;
        //      counter *= p;
        //  }
    }
}