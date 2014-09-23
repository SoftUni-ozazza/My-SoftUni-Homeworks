/*
 Problem 6.	Longest Area in Array

Write a program to find the longest area of equal elements in array of strings. 
You first should read an integer n and n strings (each at a separate line), 
then find and print the longest sequence of equal elements (first its length, then its elements).
If multiple sequences have the same maximal length, print the leftmost of them. 

 */

using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("How many strings n = ");
        int n = int.Parse(Console.ReadLine());

        // add the input in string array
        string[] stringArray = new string[n];
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

        // take the most reapeatable string
        string mostString = null;
        int holderMostString = 0;

        for (int j = 0; j < stringArray.Length; j++)
        {
            int counter = 0;
            for (int m = 0; m < stringArray.Length; m++)
            {
                if (stringArray[j] == stringArray[m])
                {
                    counter++;
                }
            }
            if (holderMostString < counter)
            {
                holderMostString = counter;
                mostString = stringArray[j];
            }
        }

        // print output
        Console.WriteLine("{0}", holderMostString);
        for (int t = 0; t < holderMostString; t++)
        {
            Console.WriteLine(mostString);
        }
        Console.WriteLine();
    }
}