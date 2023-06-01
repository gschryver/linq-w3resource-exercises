// Test Data :
// Input the number of members on the List : 5
// Member 0 : 10
// Member 1 : 48
// Member 2 : 52
// Member 3 : 94
// Member 4 : 63
// Input the value above you want to display the members of the List : 59
// Expected Output :
// The numbers greater than 59 are :
// 94
// 63


using System;
using System.Linq;

namespace ListMembersKeyboard
{
    class Program
    {
        static void Main()
        {
            // input the number of members on the list
            int numMembers;
            string userInput = "";

            Console.WriteLine("Input the number of members on the list: ");
            userInput = Console.ReadLine() ?? "";

            while (!int.TryParse(userInput, out numMembers))
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.Write("Input the number of members on the list: ");
                userInput = Console.ReadLine() ?? "";
            }

            // provide the user with the option to provide a number for the member
            // if the user does not provide a number, the default value will be 0
            List<int> list = new List<int>();
            for (int i = 0; i < numMembers; i++)
            {
                Console.Write("Member {0}: ", i);
                userInput = Console.ReadLine() ?? "";

                if (userInput == "")
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(int.Parse(userInput));
                }
            }

            int value;
            Console.Write("Input the value above you want to display the members of the list: ");
            userInput = Console.ReadLine() ?? "";

            while (!int.TryParse(userInput, out value))
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.Write(
                    "Input the value above you want to display the members of the list: "
                );
                userInput = Console.ReadLine() ?? "";
            }

            Console.WriteLine("The numbers greater than " + value + "are: ");
            foreach (int numb in list)
            {
                if (numb > value)
                {
                    Console.WriteLine(numb);
                }
            }
        }
    }
}
