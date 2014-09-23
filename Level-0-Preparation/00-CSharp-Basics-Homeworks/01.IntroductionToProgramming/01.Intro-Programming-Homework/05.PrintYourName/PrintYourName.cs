using System;

class PrintYourName
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("Your name is " + name);
    }
}