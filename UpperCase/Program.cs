// Write a program in C# Sharp to find uppercase words in a string.
// Test Data :
// Input the string : this IS a STRING
// Expected Output :
// The UPPER CASE words are :
// IS
// STRING

using System;
using System.Linq;

namespace UpperCase {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input the string: ");
            string input = Console.ReadLine() ?? string.Empty; // if the input is null, we'll just use an empty string
            string[] words = input.Split(' '); // let's split the string into an array of words
            // strip out any punctuation
            for (int i = 0; i < words.Length; i++) { 
                // TrimEnd will remove any of the characters in the array from the end of the string
                words[i] = words[i].TrimEnd(',', '.', '!', '?');
            }
            // we are using LINQ here by using the Where() method to filter out the words that are upper case
            // we're going to take a word and check if it is equal to the same word but in upper case
            var upperCaseWords = words.Where(word => word == word.ToUpper()); 
            Console.WriteLine("The UPPER CASE words are: ");
            foreach (var word in upperCaseWords) {
                Console.WriteLine(word);
            }
        }
    }
}