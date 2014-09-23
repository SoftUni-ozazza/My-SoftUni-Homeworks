/*
 Problem 14.	Modify a Bit at Given Position

We are given an integer number n, 
a bit value v (v=0 or 1) and 
a position p. 

Write a sequence of operators (a few lines of C# code) that 
modifies n to hold the value v at the position p 
from the binary representation of n while preserving all other bits in n. 

 */

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Number = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Position = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Value = ");
        int v = int.Parse(Console.ReadLine());
        int mask;
        int nAndMask;

        if (v == 0)
        {
            mask = ~(1 << p);
            nAndMask = n & mask;
        }
        else
        {
            mask = 1 << p;
            nAndMask = n | mask;
        }
        int result = nAndMask;

       // // see it in Debugger ////////////////////////////
       // string binN = Convert.ToString(n, 2).PadLeft(32, '0');
       // string binMask = Convert.ToString(mask, 2).PadLeft(32, '0');
       // string binNAndMask = Convert.ToString(nAndMask, 2).PadLeft(32, '0');
       // string binResult = Convert.ToString(result, 2).PadLeft(32, '0');
       // //////////////////////////////

        Console.WriteLine(result);

    }
}