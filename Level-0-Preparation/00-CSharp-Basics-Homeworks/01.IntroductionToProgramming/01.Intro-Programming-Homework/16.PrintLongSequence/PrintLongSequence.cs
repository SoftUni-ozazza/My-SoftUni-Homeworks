﻿using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1000 + 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}, ", i);
            }
            else
            {
                Console.Write("{0}, ", -i);
            }
        }
    }
}