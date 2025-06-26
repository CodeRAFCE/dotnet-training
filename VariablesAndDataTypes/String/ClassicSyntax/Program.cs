using System;

namespace StringClassicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing string variables
            string greeting = "Hello, World!";
            string name = "Alice";
            string message = "Welcome to C# learning!";

            // String concatenation
            string fullGreeting = greeting + " My name is " + name + ".";

            // String interpolation (recommended)
            string interpolated = $"Hi {name}, {message}";

            // Printing values
            Console.WriteLine(greeting);
            Console.WriteLine(fullGreeting);
            Console.WriteLine(interpolated);
        }
    }
}
