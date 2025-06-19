// Concept: int Data Type
// Description: Demonstrates how to declare, assign, and use int variables in C#.
// Syntax: Old (Explicit Main method, .NET Framework style)
// Author: Your Name
// Date: 2025-06-19

/*
Old Syntax Structure in C# Console Apps:

using System; // Imports the System namespace for basic functionality

namespace IntTypeOldSyntax
{
    class IntExample // Class definition
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Your code goes here
        }
    }
}
*/

using System;

namespace IntTypeOldSyntax
{
    class IntExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("Using int Data Type in C#");
            Console.WriteLine("=============================================================");

            // Declaring and initializing int variables
            int age = 25;
            int year = 2025;
            int apples = 10;
            int score = -15;

            // Performing arithmetic operations
            int sum = apples + 5;
            int difference = year - 2000;
            int product = age * 2;
            int quotient = apples / 2;
            int remainder = apples % 3;

            // Printing values
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Apples: {apples}");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("=============================================================");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
            Console.WriteLine("=============================================================");
            Console.WriteLine("Using int Data Type in C#");
            Console.WriteLine("=============================================================");
        }
    }
}
