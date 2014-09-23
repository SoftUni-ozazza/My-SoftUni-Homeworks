/*
 Problem 4.	Print a Deck of 52 Cards

Write a program that generates and prints all possible cards 
from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation 
(like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
Print each card face in its four possible suits: 
clubs, diamonds, hearts and spades. 
Use 2 nested for-loops and a switch-case statement.

output
2♣ 2♦ 2♥ 2♠
3♣ 3♦ 3♥ 3♠
…
K♣ K♦ K♥ K♠
A♣ A♦ A♥ A♠

 */

using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string clubs = Convert.ToString('\u0005');
        string diamonds = Convert.ToString('\u0004');
        string hearts = Convert.ToString('\u0003');
        string spades = Convert.ToString('\u0006');

        string[] decks2toA = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suits = new string[] { clubs, diamonds, hearts, spades };

        for (int card = 0; card < decks2toA.Length; card++)
        {
            switch (card)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    {
                        for (int suit = 0; suit < suits.Length; suit++)
                        {
                            Console.Write("{0,2}{1,1} ", decks2toA[card], suits[suit]);
                        }
                        break;
                    }
            }
            Console.WriteLine();
        }
    }
}