// Write a program in C# Sharp to find a string that starts and ends with a specific character.
// Test Data :
// The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
// Input starting character for the string : A
// Input ending character for the string : M
// Expected Output :
// The city starting with A and ending with M is : AMSTERDAM

using System;
using System.Linq;

namespace StartsEnds {
    class Program {
        static void Main() {
            string[] cities = {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};
            Console.Write("Input starting character for the string: ");
            // using convert.tochar to convert the string to char and if the input is null then it will be converted to empty string
            char start = Convert.ToChar(Console.ReadLine() ?? "");
            Console.Write("Input ending character for the string: ");
            char end = Convert.ToChar(Console.ReadLine() ?? "");
            var result = cities.Where(x => x.StartsWith(start) && x.EndsWith(end));
            Console.WriteLine($"The city starting with {start} and ending with {end} is: {result.First()}");
        }
    }
}