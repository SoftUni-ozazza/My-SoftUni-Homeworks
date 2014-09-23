/*
 Problem 14.	Decimal to Binary Number
 * 
Using loops write a program that converts 
an integer number to its binary representation. 
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality. 

 */

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long nLong = long.Parse(Console.ReadLine());
        long result = 1;
        string resultBinary = null;

        while (nLong > 0)
        {
            result = nLong % 2;
            nLong /= 2;
            if (result == 1)
            {
                resultBinary = '1' + resultBinary;
            }
            else
            {
                resultBinary = '0' + resultBinary;
            }
        }
        Console.WriteLine(resultBinary);

    }
}