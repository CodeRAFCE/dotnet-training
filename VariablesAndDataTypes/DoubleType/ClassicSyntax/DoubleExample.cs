// Concept: double Data Type
// Description: Demonstrates how to declare, assign, and use double variables in C#.
// Syntax: Classic (Explicit Main method, .NET Framework style)
// Author: Your Name
// Date: 2025-06-19

/*
Classic Syntax Structure in C# Console Apps:

using System; // Imports the System namespace for basic functionality

namespace DoubleTypeClassicSyntax
{
    class DoubleExample // Class definition
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

namespace DoubleTypeClassicSyntax
{
    class DoubleExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("Using double Data Type in C#");
            Console.WriteLine("=============================================================");

            // Declaring and initializing double variables
            double temperature = 36.6;
            double pi = 3.14159;
            double distance = 12345.6789;
            double negativeValue = -42.42;

            // Performing arithmetic operations
            double sum = temperature + pi;
            double difference = distance - temperature;
            double product = pi * 2;
            double quotient = distance / 3;
            double remainder = pi % 2;

            // Printing values
            Console.WriteLine($"Temperature: {temperature}");
            Console.WriteLine($"Pi: {pi}");
            Console.WriteLine($"Distance: {distance}");
            Console.WriteLine($"Negative Value: {negativeValue}");
            Console.WriteLine("=============================================================");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
            Console.WriteLine("=============================================================");
        }
    }
}
