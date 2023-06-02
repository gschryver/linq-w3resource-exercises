// Write a program in C# Sharp to convert a string array to a string.
// Test Data :
// Input number of strings to store in the array :3
// Input 3 strings for the array :
// Element[0] : cat
// Element[1] : dog
// Element[2] : rat
// Expected Output:
// Here is the string below created with elements of the above array :
// cat, dog, rat


using System;
using System.Linq;

namespace ArrayToString {
    class Program {
        static void Main() {
            // string[] animals = { "cat", "dog", "rat" };
            string[] animals = new string[3];
            Console.Write("Input number of strings to store in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} strings for the array: ", n);
            for (int i = 0; i < n; i++) {
                Console.Write("Element[{0}]: ", i);
                animals[i] = Console.ReadLine() ?? throw new ArgumentNullException();
            }
            Console.WriteLine("Here is the string below created with elements of the above array: ");
            // using string to join the array
            Console.WriteLine(string.Join(", ", animals));
        }
    }
}