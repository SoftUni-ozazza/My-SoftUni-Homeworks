/*
 Problem 3.	Check for a Play Card

Classical play cards use the following signs to designate the card face: 
        2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that 
        enters a string and 
        prints “yes” if it is a valid card sign or “no” otherwise. 

 */

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string[] pack = new string[13];

        int card = 2;
        for (int i = 0; i < 9; i++)
        {
            pack[i] = Convert.ToString(card);
            card++;
        }
        pack[9] = "J";
        pack[10] = "Q";
        pack[11] = "K";
        pack[12] = "A";

        string input = Console.ReadLine();

        bool valid = false;
        for (int m = 0; m < pack.Length; m++)
        {
            if (pack[m] == input)
            {
                valid = true;
                Console.WriteLine("yes");
                break;
            }
        }
        if (!valid)
        {
            Console.WriteLine("no");
        }
    }
}