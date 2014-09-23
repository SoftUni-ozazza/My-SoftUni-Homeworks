/*
 Problem 10.	Fibonacci Numbers

Write a program that reads a number n and 
prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by spaces) : 
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 

Note that you may need to learn how to use loops. 

 */

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int first = 0;
        int second = 1;
        int firstLength = 0;

        for (int i = 0; i < n; i++)
        {
            string stringFirst = Convert.ToString(first);
            firstLength += stringFirst.Length + 1;
            Console.SetCursorPosition(firstLength, 0);

            Console.Write(" " + first + " ");

            int third = first + second;
            first = second;
            second = third;
        }
    }
}