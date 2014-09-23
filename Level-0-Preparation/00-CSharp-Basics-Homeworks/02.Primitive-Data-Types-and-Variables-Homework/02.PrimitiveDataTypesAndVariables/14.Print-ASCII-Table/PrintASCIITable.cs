/*
 Problem 14.	* Print the ASCII Table
Find online more information about ASCII 
(American Standard Code for Information Interchange) and 
write a program to prints the entire ASCII table of characters 
at the console (characters from 0 to 255). 

Note that some characters have a special purpose and will not be 
displayed as expected. You may skip them or display them differently. 
You may need to use for-loops (learn in Internet how).

 */

using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;

        for (byte i = 0; i <= 255; i++)
        {
            Console.WriteLine((char)i);
        }

        // FROM INTERNET:
        //  int column = 0;
        //  for (byte counter = 32; counter < 128; counter++)
        //  {
        //      if (column == 0)
        //      {
        //          Console.Write("0x{0:X}  ", counter);
        //      }
        //      Console.Write(" {0}  ", (char)counter);
        //      if (++column > 7)
        //      {
        //          column = 0;
        //          Console.WriteLine();
        //      }
        //  
        //  }
        //  Console.ReadLine();
    }
}