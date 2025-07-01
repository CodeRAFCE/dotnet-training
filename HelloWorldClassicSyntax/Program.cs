using System;
using PasswordGenerator;


namespace HelloWorldClassicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();
            GenerateAndPrintPassword();
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        static void GenerateAndPrintPassword()
        {
            // Create a password generator instance
            var pwd = new Password();
            // Generate a random password (default length is 8)
            string password = pwd.Next();
            Console.WriteLine($"Generated Password: {password}");
        }
    }
}
