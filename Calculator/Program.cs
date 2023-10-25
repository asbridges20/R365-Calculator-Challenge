// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace R365.Calculator
{
    class Calculator
    {
        static void Main()
        {
            // Create delimiter list and variables for user input and accumulator.
            string input;
            int total = 0;
            int num;

            // User input request
            Console.WriteLine("Please enter a series of numbers separated only by commas:");

            input = Console.ReadLine();

            // Parse the user input based on 
            string[] tokens = input.Split(',');

            // Confirm the number of entries is 2, if more, throw exception
            if (tokens.Length > 2)
            {
                throw new ArgumentException("Up to 2 numbers separated by a comma are allowed.");
               
            }

            // Parse tokens into int variable and sum total if positive or add to separate list if negative.
            foreach (string str in tokens)
            {
                // Convert tokened strings to int variable, convert to zero if invalid
                if (int.TryParse(str, out num))
                    {
                     total += num;
                    }
            }

            Console.WriteLine("The total sum of your entry is: " + total);
            Console.WriteLine("Ok, bye.");
            Environment.Exit(0);

        }
    }
}




