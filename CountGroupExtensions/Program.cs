/* 
Write a program in C# Sharp to count file extensions and group it using LINQ.
Test Data :
The files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf
aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt
Expected Output :
Here is the group of extension of the files :
1 File(s) with .frx Extension
3 File(s) with .txt Extension
1 File(s) with .dbf Extension
2 File(s) with .pdf Extension
1 File(s) with .frt Extension
1 File(s) with .xml Extension 
*/

using System;
using System.Linq;

namespace CountGroupExtensions
{
    class Program
    {
        static void Main() {
            string[] files = {"aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt"};

            var fileGroups = files.GroupBy(file => file.Split('.').Last().ToLower()).OrderBy(group => group.Key);

            foreach (var group in fileGroups) {
                Console.WriteLine($"{group.Count()} File(s) with .{group.Key} Extension");
            }
        }
    }
}