// Write a program in C# Sharp to find the n-th maximum grade point achieved by the students from the list of students.
// Test Data :
// Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : 3
// Expected Output:
// Id : 7, Name : David, achieved Grade Point : 750
// Id : 10, Name : Jenny, achieved Grade Point : 750

using System;
using System.Linq;

namespace MaximumGrade {
    class Program {
        static void Main (string[] args) {
            int[] id = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] name = { "Joel", "David", "Jenny", "Tim", "Nic", "Arnold", "Marquise", "Kathleen", "Amanda", "Gloria" };
            int[] grade = { 750, 760, 770, 780, 790, 800, 810, 820, 830, 840 };

            Console.Write ("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find: ");
            int num = Convert.ToInt32 (Console.ReadLine () ?? throw new InvalidOperationException ());

            // sort by descending order. distinct removes duplicates. we then convert to array.
            var gradeRank = grade.OrderByDescending (g => g).Distinct ().ToArray ();

            for (int i = 0; i < num; i++) { 
                for (int g = 0; g < grade.Length; g++) { 
                    if (gradeRank[i] == grade[g]) { 
                        Console.WriteLine ("Id: {0}, Name: {1}, achieved Grade Point: {2}", id[g], name[g], grade[g]);
                    } 
                }
            }
        }
    }
}
            

        
