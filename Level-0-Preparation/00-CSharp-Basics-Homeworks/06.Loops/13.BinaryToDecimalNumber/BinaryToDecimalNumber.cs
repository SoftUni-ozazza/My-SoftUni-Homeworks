/*
 Problem 13.	Binary to Decimal Number
 
Using loops write a program that converts 
a binary integer number to its decimal form. 
The input is entered as string. The output should be a variable of type long. 

Do not use the built-in .NET functionality. 
Examples:
binary	                        decimal
0	                            0
11	                            3
1010101010101011	            43691
1110000110000101100101000000	236476736

 */

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("binary n = ");
        string nString = Console.ReadLine();
        int result = 0;
        int bit = 0;
        if (nString.Length <= 63)
        {
            for (int i = nString.Length - 1; i >= 0; i--, bit++)
            {
                if (nString[i] == '1')
                {
                    int number = 1 << bit;
                    result |= number;

                    // see the binary representation at the console
                    //Console.WriteLine(Convert.ToString(number, 2).PadLeft(64, '0') + " number");
                    //Console.WriteLine(Convert.ToString(result, 2).PadLeft(64, '0') + " result");
                    //Console.WriteLine("------------------------------------------------------------------------");
                }
            }
            long resultToLong = (long)result;
            Console.WriteLine(resultToLong);
        }
        else
        {
            Console.WriteLine("The number is too big!");
        }
    }
}