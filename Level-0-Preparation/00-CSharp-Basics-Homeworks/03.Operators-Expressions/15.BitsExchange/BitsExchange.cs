/*
 Problem 15.	* Bits Exchange

Write a program that exchanges 
        bits 3, 4 and 5 with 
        bits 24, 25 and 26 of given 
        32-bit unsigned integer. 
 * Examples:    1140867093 --> 1107312677;
 *              4294901775 --> 4194238527;
 *              5351       --> 67114183;
    
 */

using System;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p3 = 3;
        int p24 = 24;

        // bitwise int and uint - see reff.:  http://social.msdn.microsoft.com/Forums/en-US/1e9d6e3b-bbad-45df-9391-7403becd9641/shift-operator-cannot-be-applied-to-uint?forum=csharpgeneral
        // 7 in binary is 111 --> operation over 3 bits
        uint maskP3to5 = 7u << p3;
        uint maskP24to26 = 7u << p24;

        // get the bits
        uint bits3to5 = (n & maskP3to5) >> p3;        
        uint bits24to26 = (n & maskP24to26) >> p24;

        // adding masks together
        uint bothMasks = maskP3to5 | maskP24to26;

        // uncomment to see binary representation in debugger:
        string bin_n = Convert.ToString(n, 2).PadLeft(64, '0');
        string bin_MaskP3to5 = Convert.ToString(maskP3to5, 2).PadLeft(64, '0');
        string bin_MaskP24to26 = Convert.ToString(maskP24to26, 2).PadLeft(64, '0');
        string bin_bits3to5 = Convert.ToString(bits3to5, 2).PadLeft(64, '0');
        string bin_bits24to26 = Convert.ToString(bits24to26, 2).PadLeft(64, '0');
        string bin_bothMasks = Convert.ToString(bothMasks, 2).PadLeft(64, '0');

        // set 6 positions at n to 0
        uint nBitsToZero = (n & (~bothMasks));
        
        // exchange masks
        maskP3to5 = bits24to26 << p3;
        maskP24to26 = bits3to5 << p24;

        // adding new masks together
        bothMasks = maskP3to5 | maskP24to26;        

        // adding bothMasks to number with 6 zero-bits positions
        uint newNumber = nBitsToZero ^ bothMasks;

        // uncomment to see binary representation in debugger:
        string bin_nBitsToZero = Convert.ToString(nBitsToZero, 2).PadLeft(64, '0');
        string bin_maskP3to5 = Convert.ToString(maskP3to5, 2).PadLeft(64, '0');
        string bin_maskP24to26 = Convert.ToString(maskP24to26, 2).PadLeft(64, '0');
        bin_bothMasks = Convert.ToString(bothMasks, 2).PadLeft(64, '0');
        string bin_newNumber = Convert.ToString(newNumber, 2).PadLeft(64, '0');

        Console.WriteLine(newNumber);

    }
}