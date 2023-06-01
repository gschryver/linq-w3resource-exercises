// Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
// Test Data :
// The members of the list are :
// 55 200 740 76 230 482 95
// Expected Output :
// The numbers greater than 80 are :
// 200
// 740
// 230
// 482
// 95

using System;
using System.Linq;

namespace GreaterThanEighty
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 55, 200, 740, 76, 230, 482, 95 };

            var greaterThanEighty = from num in numbers where num > 80 select num;

            Console.WriteLine("The numbers greater than 80 are:");
            foreach (int num in greaterThanEighty)
            {
                Console.WriteLine(num);
            }
        }
    }
}
