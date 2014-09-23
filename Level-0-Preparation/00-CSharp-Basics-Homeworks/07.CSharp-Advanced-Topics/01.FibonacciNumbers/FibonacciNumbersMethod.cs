/*
 Problem 1.	Fibonacci Numbers

Define a method Fib(n) that calculates the n-th Fibonacci number. 

 */

using System;

class FibonacciNumbersMethod
{

    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        CalcAndPrintNthFibonacci(n);
    }

    static void CalcAndPrintNthFibonacci(int number)
    {
        int zero = 1;
        int first = 1;
        int second = 2;
        int result = 0;

        if (number == 0)
        {
            result = zero;
        }
        else if (number == 1)
        {
            result = first;
        }
        else
        {
            for (int i = 2; i <= number; i++)
            {
                second = zero + first;  //2 3 5 8
                zero = first;           //1 2 3 5
                first = second;         //2 3 5 8
            }
            result = second;
        }

        Console.WriteLine("{0}-th fibonacci number is {1}", number, result);
    }

}