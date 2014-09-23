/* 
Problem 1.	Declare Variables

Declare five variables choosing for each of them the most 
appropriate of the types 
    byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
    52130, -115, 4825932, 97, -10000. 
 Choose a large enough type for each number to ensure it will fit in it. 
 Try to compile the code. Submit the source code of your Visual Studio project as 
 part of your homework submission.
*/

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort nUShort = 52130;
        sbyte nSByte = -115;
        int nInt = 4825932;
        byte nByte = 97;
        short nShort = -10000;
        
        Console.WriteLine("{0} is ushort ", nUShort);
        Console.WriteLine();
        Console.WriteLine("{0} is sbyte", nSByte);
        Console.WriteLine();
        Console.WriteLine("{0} is integer", nInt);
        Console.WriteLine();
        Console.WriteLine("{0} is byte", nByte);
        Console.WriteLine();
        Console.WriteLine("{0} is short type", nShort);
        Console.WriteLine();
    }
}