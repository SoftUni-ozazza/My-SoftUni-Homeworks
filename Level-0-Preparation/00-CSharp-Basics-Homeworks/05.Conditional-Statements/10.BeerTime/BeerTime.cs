/*
 Problem 10.	* Beer Time

A beer time is after 1:00 PM and before 3:00 AM. 
Write a program that 
    enters 
    a time in format “hh:mm tt” (an hour in range [01...12], 
    a minute in range [00…59] and AM / PM designator) and 
prints “beer time” or “non-beer time” according to 
the definition above or “invalid time” if the time cannot be parsed. 
 
Note that you may need to learn how to parse dates and times. 

 */

using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        TimeSpan startBeerTime = TimeSpan.Parse("13:00");
        TimeSpan endBeerTime = TimeSpan.Parse("03:00");

        Console.WriteLine("Enter a time in format \"hh:mm tt\" : ");
        string time = Console.ReadLine();

        DateTime timeInput = new DateTime();
        bool isValid = DateTime.TryParse(time, out timeInput);

        if (isValid)
        {
            timeInput = DateTime.ParseExact(time, "h:mm tt", Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"));

            // is it a beer time?
            if (TimeSpan.Compare(timeInput - timeInput.Date, startBeerTime) == 1 ||
                TimeSpan.Compare(timeInput - timeInput.Date, startBeerTime) == 0 ||
                TimeSpan.Compare(timeInput - timeInput.Date, endBeerTime) == -1)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}