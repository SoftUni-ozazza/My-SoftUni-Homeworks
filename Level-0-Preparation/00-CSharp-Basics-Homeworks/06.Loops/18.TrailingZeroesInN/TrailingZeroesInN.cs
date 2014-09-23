/*
 Trailing Zeroes in N!
 * 
Write a program that calculates with how many zeroes the factorial 
of a given number n has at its end. 
Your program should work well for very big numbers, e.g. n=100000. 

*/

using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        // calculating the n!
        BigInteger nFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        string nFactString = Convert.ToString(nFactorial);
        int length = nFactString.Length - 1;

        // ---> counting as a string

        // counting the zeroes from the last to the first char if any
        int counter = 1;
        if (nFactString[length] == '0')
        {
            for (int s = 1; s < nFactString.Length; s++)
            {
                if (nFactString[length - s] == '0')
                {
                    counter++;
                }
                else
                {
                    if (n > 7100)
                    {
                        Console.WriteLine("trailing zeros = {0}", counter);
                        Console.WriteLine("example is too big to be shown");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("trailing zeros = {0}", counter);
                        Console.WriteLine("{0}! = {1}", n, nFactString);
                        return;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("no trailing zeroes");
        }

        // ---> counting as a number

        // counting the zeroes from the last to the first char if any
        //int counter = 0;
        //if (nFactString[length] == '0')
        //{
        //    for (int s = 1; s <= length + 1; s++)
        //    {
        //        bool isZero = ((nFactorial & (1 << s)) >> s) == 0; /////// the bit expression isn't working
        //        if (isZero)
        //        {
        //            counter++;
        //        }
        //        else                                            ////// and never comes at that case
        //        {
        //            Console.WriteLine("trailing zeros = {0}", counter);
        //            Console.WriteLine("{0}! = {1}", n, nFactString);
        //            return;
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("no trailing zeroes");
        //}
    }
}