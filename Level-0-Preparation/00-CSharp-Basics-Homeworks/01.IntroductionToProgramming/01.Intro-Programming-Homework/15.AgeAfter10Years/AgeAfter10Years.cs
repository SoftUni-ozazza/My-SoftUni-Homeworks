using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Write your birthday ");
        string birthday = Console.ReadLine();

        DateTime birthTime = DateTime.Parse(birthday);

        DateTime after10Years = DateTime.Now.AddYears(10);
        TimeSpan now = DateTime.Now - birthTime;

        TimeSpan yearsAfter = after10Years - birthTime;

        Console.WriteLine((int)(now.Days / 365.25) + " years");
        Console.WriteLine((int)(yearsAfter.Days / 365.25) + " years");



    }
}