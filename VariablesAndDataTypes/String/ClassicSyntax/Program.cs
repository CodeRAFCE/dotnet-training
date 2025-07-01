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

            // String length
            int greetingLength = greeting.Length;

            // Substring
            string sub = greeting.Substring(0, 5); // "Hello"

            // ToUpper and ToLower
            string upper = name.ToUpper();
            string lower = name.ToLower();

            // Replace
            string replaced = greeting.Replace("World", name);

            // Contains
            bool hasWelcome = message.Contains("Welcome");

            // Printing values
            Console.WriteLine(greeting);
            Console.WriteLine(fullGreeting);
            Console.WriteLine(interpolated);
            Console.WriteLine($"Length of greeting: {greetingLength}");
            Console.WriteLine($"Substring: {sub}");
            Console.WriteLine($"Upper: {upper}, Lower: {lower}");
            Console.WriteLine($"Replaced: {replaced}");
            Console.WriteLine($"Message contains 'Welcome': {hasWelcome}");
        }
    }
}
