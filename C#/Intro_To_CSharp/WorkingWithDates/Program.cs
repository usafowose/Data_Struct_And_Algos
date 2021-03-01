﻿using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a custom DateTime object pointing to any point in time.
            DateTime dateTime = new DateTime(2021, 2, 24);
            //Console.WriteLine(dateTime);
            // Getting the current time when the code is run, down to the second. 
            DateTime now = DateTime.Now;
            //Console.WriteLine(now);
            //Getting the current day when the code is run, without including the time of day
            DateTime today = DateTime.Today;

            //Modifying DateTime Objects
            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("dddd, MMMM dd yyyy hh:mm:ss"));


            //Console.WriteLine("------------------------");
            //Console.WriteLine(today);
            //Console.WriteLine(today.ToLongDateString());

            //Console.WriteLine();
            //Console.WriteLine(today.Hour);
            //Console.WriteLine(today.Minute);
            //Console.WriteLine();


            //Console.WriteLine(today.DayOfWeek);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.Minute);
            //Console.WriteLine(now.DayOfWeek);
            
      

        }
    }
}
