// Write a program in C# Sharp to display the number and frequency of a given number from an array.
// Expected Output :
// The number and the Frequency are :
// Number 5 appears 3 times
// Number 9 appears 2 times
// Number 1 appears 1 times

using System;
using System.Linq;

namespace Frequency {
    class Program {
        static void Main () {
            int[] number = new int[] { 1, 5, 9, 5, 9, 5 };

            var numberQuery = from num in number
            // group works by grouping the numbers in the array, by the number itself, into a new variable called numGroup
            group num by num into numGroup 
            orderby numGroup.Key // order the numbers by the key, which is the number itself
            select numGroup;

            foreach (var numGroup in numberQuery) {
                Console.WriteLine ("Number " + numGroup.Key + " appears " + numGroup.Count () + " times");
            }
        }
    }
}

