// Write a program in C# Sharp to display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
// Test Data :
// The numbers in the array are :
// 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
// Expected Output :
// Number Number*Frequency Frequency
// ------------------------------------------------
// 5 15 3
// 1 1 1
// 9 9 1
// 2 4 2

using System;
using System.Linq;

namespace MultiplyFrequency {
    class Program {
        static void Main() {
            int[] numbers = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var numFrequency = from num in numbers
                               group num by num into g
                               select new { Number = g.Key, Frequency = g.Count() };

                               foreach (var num in numFrequency) {
                                   Console.WriteLine($"{num.Number} {num.Number * num.Frequency} {num.Frequency}");
                               }
        }
    }
}