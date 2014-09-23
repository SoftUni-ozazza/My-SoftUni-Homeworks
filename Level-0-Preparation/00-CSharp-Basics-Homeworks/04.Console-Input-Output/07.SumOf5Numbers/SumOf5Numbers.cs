/*
 Problem 7.	Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, 
separated by a space), calculates and prints their sum. 

 */

using System;

class SumOf5Numbers
{
    static void Main()
    {
        int inputTimes = 5;
        decimal number = 0;
        decimal result = 0;
        int numberLength = 0;
        
        for (int i = 1; i <= inputTimes; i++)
        {
            number = decimal.Parse(Console.ReadLine());

            // result = result + number;
            result += number;                           

            // counting the length of the number
            string numberString = Convert.ToString(number);

            // an addition of the current length of the row
            numberLength += numberString.Length + 1;

            // set the cursor position at the end of the length
            Console.SetCursorPosition(numberLength, 0);
        }

        Console.WriteLine(result);
    }
}