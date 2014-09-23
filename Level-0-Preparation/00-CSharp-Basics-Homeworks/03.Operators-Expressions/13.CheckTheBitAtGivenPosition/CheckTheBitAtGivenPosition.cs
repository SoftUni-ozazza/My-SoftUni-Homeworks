/*
 Problem 13.	Check a Bit at Given Position

Write a Boolean expression that returns 
    if the bit at position p (counting from 0, starting from the right) 
    in given integer number n has value of 1. 

 */

using System;

class CheckTheBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Bit position: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        int bitValue = 1;
        
        bool result = bit == bitValue;
        Console.WriteLine(result);
    }
}