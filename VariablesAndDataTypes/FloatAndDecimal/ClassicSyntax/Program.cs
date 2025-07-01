using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace FloatAndDecimalClassicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // FLOAT EXAMPLES
            float temperature = 36.6f;
            float pi = 3.14159f;
            float smallValue = 0.0001f;
            float sumFloat = temperature + pi;
            float productFloat = temperature * 2;

            Console.WriteLine("--- Float Examples ---");
            Console.WriteLine($"Temperature: {temperature}");
            Console.WriteLine($"Pi: {pi}");
            Console.WriteLine($"Small Value: {smallValue}");
            Console.WriteLine($"Sum: {sumFloat}");
            Console.WriteLine($"Product: {productFloat}");
            Console.WriteLine($"ToString: {pi.ToString()}");

            // DECIMAL EXAMPLES
            decimal price = 19.99m;
            decimal tax = 1.50m;
            decimal total = price + tax;
            decimal productDecimal = price * 3;

            Console.WriteLine("--- Decimal Examples ---");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Product: {productDecimal}");
            Console.WriteLine($"ToString: {total.ToString()}");

            // Comparing float and decimal
            Console.WriteLine("--- Comparison ---");
            Console.WriteLine($"Float sum (temperature + pi): {sumFloat}");
            Console.WriteLine($"Decimal sum (price + tax): {total}");
        }
    }
}
