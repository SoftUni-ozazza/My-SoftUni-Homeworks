﻿/*
 Problem 9.	Matrix of Numbers
 
Write a program that reads from the console 
a positive integer number n (1 ≤ n ≤ 20) and 
prints a matrix like in the examples below. 
Use two nested loops. 

Examples:
n	matrix	|	n	matrix	|	n	matrix
2	1 2     |               |
    2 3	    |   3	1 2 3   |
            |       2 3 4   |
            |       3 4 5	|  	4	1 2 3 4
                            |       2 3 4 5
                            |       3 4 5 6
                            |       4 5 6 7

 */

using System;

class MatrixNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col < row + n; col++)
            {
                Console.Write("{0,2} ", col);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}