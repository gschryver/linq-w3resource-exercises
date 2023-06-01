// Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.
// Expected Output:
// The numbers within the range of 1 to 11 are :
// 1 3 6 9 10

using System;
using System.Linq;

namespace ListOfNumbers {
    class Program {
        static void Main () {
            int[] number = new int[] { 1, 3, 6, 9, -1, 0, 10, -2, -4, -8, 12, 13, 15, 16, 17, 19, -20 };

            var numberQuery = from num in number
            where num > 0 && num < 11 // if number is greater than 0 and less than 11
            select num; // select number

            foreach (int num in numberQuery) {
                Console.Write (num + " ");
            }
        }
    }
}