/*
 Problem 4.	Multiplication Sign
 
Write a program that shows the sign (+, - or 0) of the product of 
three real numbers, without calculating it. 
Use a sequence of if operators. 

 */

using System;

class MultiplicationSign
{
    static void Main()
    {
        decimal number;
        int minus = 0;
        string result = null;

        for (int i = 0; i < 3; i++)
        {
            number = decimal.Parse(Console.ReadLine());

            if (number == 0)
            {
                result = "0";
                break;
            }
            if (number < 0)
            {
                minus++;
            }
        }
        if (result == "0")
        {
            Console.WriteLine(result);
        }
        else
        {
            if ((minus == 1) || (minus == 3))
            {
                result = "-";
            }
            else
            {
                result = "+";
            }
            Console.WriteLine(result);
        }
    }
}