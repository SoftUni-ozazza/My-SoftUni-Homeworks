﻿/*
 Problem 10.	Odd and Even Product
 
You are given n integers (given in a single line, separated by a space). 
Write a program that checks whether 
the product of the odd elements is equal to the product of the even elements. 
Elements are counted from 1 to n, so 
the first element is odd, the second is even, etc. 
Examples:

numbers	        result
------------------------------
2 1 1 6 3	    yes
                product = 6
------------------------------
3 10 4 6 5 1	yes
                product = 60
------------------------------
4 3 2 5 2	    no
                odd_product = 16
                even_product = 15
------------------------------
 */

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("numbers are ");
        string[] tokens = Console.ReadLine().Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int even = 0; even < tokens.Length; even += 2)
        {
            evenProduct *= Convert.ToInt32(tokens[even]);
        }
        for (int odd = 1; odd < tokens.Length; odd += 2)
        {
            oddProduct *= Convert.ToInt32(tokens[odd]);
        }

        bool equal = evenProduct == oddProduct;
        if (equal)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd product = {0}", oddProduct);
            Console.WriteLine("even product = {0}", evenProduct);
        }
        Console.WriteLine();
    }
}