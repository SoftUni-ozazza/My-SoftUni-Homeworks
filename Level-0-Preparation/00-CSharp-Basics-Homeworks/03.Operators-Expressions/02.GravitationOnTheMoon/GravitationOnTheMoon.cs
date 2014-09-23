﻿/*
 Problem 2.	Gravitation on the Moon

The gravitational field of the Moon is approximately 
17% of that on the Earth. Write a program that calculates 
the weight of a man on the moon by a given weight on the Earth. 

 */

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        decimal earthWeight = decimal.Parse(Console.ReadLine());
        decimal moonWeight = (earthWeight / 100) * 17;

        Console.WriteLine(moonWeight);
    }
}
