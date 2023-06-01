// Write a program in C# Sharp to find the number of an array and the square of each number.
// Expected Output :
// { Number = 9, SqrNo = 81 }
// { Number = 8, SqrNo = 64 }
// { Number = 6, SqrNo = 36 }
// { Number = 5, SqrNo = 25 }

using System;
using System.Linq;

namespace SquareOfNumber {
    class Program {
        static void Main ()
        {
            var number = new int[] { 9, 8, 6, 5 };

            var numberQuery = from num in number
                              let sqrNum = num * num
                              select new { Number = num, SqrNo = sqrNum };

            foreach (var num in numberQuery) {
                Console.WriteLine (num);
            }
        }
    }
}
