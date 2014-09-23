/*
Problem 3.	Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of 
        n integer numbers and returns 
        the minimal, the maximal number, the sum and the average 
of all numbers (displayed with 2 digits after the decimal point). 

The input starts by the number n (alone in a line) 
followed by n lines, each holding an integer number. 
The output is like in the examples below. 

 */

using System;

class MinMaxSumAverageOfN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }

        int min = numbers[0];
        int max = numbers[0];
        int sum = numbers[0];

        for (int num = 0; num < numbers.Length; num++)
        {
            if ((num + 1) <= (n - 1))
            {
                min = Math.Min(Math.Min(min, numbers[num]), numbers[num + 1]);
                max = Math.Max(Math.Max(max, numbers[num]), numbers[num + 1]);
                sum += numbers[num + 1];
            }
        }
        double average = (double)sum / (double)n;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:F2}", average);
    }
}
