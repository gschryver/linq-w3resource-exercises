// Write a program in C# Sharp to display the top n-th records using LINQ.
// Test Data :
// The members of the list are :
// 5
// 7
// 13
// 24
// 6
// 9
// 8
// 7
// How many records you want to display ? : 3
// Expected Output :
// The top 3 records from the list are :
// 24
// 13
// 9

using System;
using System.Linq;

namespace DisplayTopRecords {
    class Program {
        static void Main() {
            int[] numbers = { 5, 7, 13, 24, 6, 9, 8, 7 };
            Console.WriteLine("The members of the list are: ");
            foreach (var num in numbers) {
                Console.WriteLine(num);
            }
            
            Console.Write("How many records you want to display?: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The top {0} records from the list are: ", n);
            var topN = numbers.OrderByDescending(num => num).Take(n); // using LINQ: descending order, then take the top n numbers
            foreach (var num in topN) {
                Console.WriteLine(num);
            }       
        }
    }
}