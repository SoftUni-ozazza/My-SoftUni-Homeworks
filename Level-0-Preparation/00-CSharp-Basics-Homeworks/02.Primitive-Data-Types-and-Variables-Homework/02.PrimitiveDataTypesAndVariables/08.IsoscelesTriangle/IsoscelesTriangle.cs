/*
 Problem 8.	Isosceles Triangle
Write a program that prints an isosceles triangle of 
9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly 
at the console so you may need to change 
the console character encoding to UTF-8 and 
assign a Unicode-friendly font in the console. 

Note also, that under old versions of Windows 
the © symbol may still be displayed incorrectly, 
regardless of how much effort you put to fix it.

 */

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        // We will build a rectangle with height = 4 and width = 7
        
        // The triangle will have copyright points and 
        // the other points will be empty points
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        string nullString = " ";
        char copyright = '\u00A9';

        for (int row = 3; row >= 0; row--)
        {
                // These are the first 4 columns of each row
            for (int col = 1; col <= 4; col++)
            {
                    // This will isolate the last row
                if (row == 0)
                {
                        // if col is an even number
                    if (col % 2 != 0)
                    {
                        Console.Write(copyright);
                    }
                    else
                    {
                        Console.Write(nullString);
                    }
                }

                    // At the other rows we're looking for dependancy
                else if ((col == row + 1) && (row > 0))
                {
                    Console.Write(copyright);
                }
                else
                {
                    Console.Write(nullString);
                }
            }

                // This code build the columns from 5 to 7 at each row
            for (int col = 0; col <= 2; col++)
            {              
                    // Again we isolate the last row, because it have a diffrent logic
                if (row == 0)
                {
                        // Here, the even number will be an empty string
                    if (col % 2 != 0)
                    {
                        Console.Write(nullString);
                    }
                    else
                    {
                        Console.Write(copyright);
                    }
                }
                else if (col == ~(row - 3))
                {
                    Console.Write(copyright);
                }
                else
                {
                    Console.Write(nullString);
                }
            }
                //We build each row at a new line
            Console.WriteLine();
        }
    }
}