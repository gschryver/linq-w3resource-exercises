// Write a program in C# Sharp to display the characters and frequency of each character in a given string.
// Test Data:
// Input the string: apple
// Expected Output:
// The frequency of the characters are :
// Character a: 1 times
// Character p: 2 times
// Character l: 1 times
// Character e: 1 times

using System;
using System.Linq;

namespace DisplayCharacters {
    class Program {
        static void Main() {
            Console.Write("Input string: ");
            string input = Console.ReadLine() ?? string.Empty;

            var frequency = from c in input
                            group c by c into g // group characters based on their value into a new group
                            select g; // select the group

            foreach (var character in frequency) {
                Console.WriteLine("Character {0}: {1} times", character.Key, character.Count());
            }
        }
    }
}