/*
 Problem 1.	Exchange If Greater 

Write an if-statement that takes two 
    integer variables a and b 
and exchanges their values if the first one is greater than the second one. 
As a result print the values a and b, separated by a space. 
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        string aStr = Console.ReadLine();
        int aInt;

        string bStr = Console.ReadLine();
        int bInt;

        bool isIntegerA = Int32.TryParse(aStr, out aInt);
        bool isIntegerB = Int32.TryParse(bStr, out bInt);

        if (isIntegerA && isIntegerB)
        {
            aInt = int.Parse(aStr);
            bInt = int.Parse(bStr);

            int c = bInt;

            if (aInt > bInt)
            {
                bInt = aInt;
                aInt = c;
            }
            Console.WriteLine("{0} {1}", aInt, bInt);
        }
        else
        {
            Console.WriteLine("{0} {1}", aStr, bStr);
        }
    }
}