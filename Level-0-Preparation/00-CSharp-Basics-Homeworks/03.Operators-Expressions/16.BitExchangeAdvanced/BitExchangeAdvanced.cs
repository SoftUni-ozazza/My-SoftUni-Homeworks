/*
 Problem 16.	** Bit Exchange (Advanced)

Write a program that exchanges 
        bits {p, p+1, …, p+k-1} with 
        bits {q, q+1, …, q+k-1} of a given 
        (n) 32-bit unsigned integer. 
The first and the second sequence of bits may not overlap. 

 */

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Number = ");
        long n = long.Parse(Console.ReadLine());

        Console.Write("bit p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("bit q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("bits k = ");
        int k = int.Parse(Console.ReadLine());

        if (Math.Abs(p - q) <= k)
        {
            Console.WriteLine("overlapping");
            return;
        }
        if ((p + k > 31) || (q + k > 31))
        {
            Console.WriteLine("out of range");
            return;
        }
        if ((p < 0) || (q < 0) || (k > 31))
        {
            Console.WriteLine("out of range");
            return;
        }
        // Creating the kMask --->
        long firstBit = 2L;
        long kMask = 1L;

        for (int bit = 0; bit < k - 1; bit++)
        {
            kMask *= firstBit;
        }

        // adding 1 to all zeroes before bit k
        for (int bitInMask = 0; bitInMask < k - 1; bitInMask++)
        {
            long addOnesToMask;
            addOnesToMask = 1 << bitInMask;
            kMask = kMask | addOnesToMask;
        }
        // Creating the kMask <---

        // Creating the masks for bit p and bit q
        long pMask = kMask << p;
        long qMask = kMask << q;

        // Getting the bits
        long bitsPtoK = (n & pMask) >> p;
        long bitsQtoK = (n & qMask) >> q;

        // Add masks together and set bits positions to zero
        long bothMasks = pMask | qMask;
        long nBitsToZero = n & (~bothMasks);

        // Exchange 
        pMask = bitsQtoK << p;
        qMask = bitsPtoK << q;

        bothMasks = pMask | qMask;

        long result = nBitsToZero ^ bothMasks;

        Console.WriteLine(result);
    }
}