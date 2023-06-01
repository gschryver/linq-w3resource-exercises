//  Write a program in C# Sharp to show how the three parts of a query operation execute.
// Expected Output:
// The numbers which produce the remainder 0 after divided by 2 are :
// 0 2 4 6 8

using System;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main() 
        {
            // The Three Parts of a LINQ Query:
            int[] number = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8}; // Data source

            var numberQuery = from num in number 
                              where (num % 2) == 0  
                              select num;

            foreach (int num in numberQuery)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}