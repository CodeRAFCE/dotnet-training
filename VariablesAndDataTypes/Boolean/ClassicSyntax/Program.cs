using System;

namespace BooleanClassicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing bool variables
            bool isActive = true;
            bool isComplete = false;
            bool isAdult = (20 >= 18); // true

            // Logical operations
            bool result1 = isActive && isComplete; // false
            bool result2 = isActive || isComplete; // true
            bool result3 = !isComplete; // true

            // Printing values
            Console.WriteLine($"isActive: {isActive}");
            Console.WriteLine($"isComplete: {isComplete}");
            Console.WriteLine($"isAdult: {isAdult}");
            Console.WriteLine($"isActive AND isComplete: {result1}");
            Console.WriteLine($"isActive OR isComplete: {result2}");
            Console.WriteLine($"NOT isComplete: {result3}");

            // Using bool in an if statement
            if (isAdult)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
        }
    }
}
