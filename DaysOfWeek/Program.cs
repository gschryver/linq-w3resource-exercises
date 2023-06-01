// Write a program in C# Sharp to display the name of the days of the week.
// Expected Output:
// Sunday
// Monday
// Tuesday
// Wednesday
// Thursday
// Friday
// Saturday

using System;
using System.Linq;

namespace Days
{
    class Program
    {
        static void Main()
        {
            string[] days =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            var day = from d in days 
            select d;

            foreach (var d in day)
            {
                Console.WriteLine(d);
            }
        }
    }
}
