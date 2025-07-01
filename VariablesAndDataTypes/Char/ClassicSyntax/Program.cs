using System;

namespace CharClassicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing char variables
            char letter = 'A';
            char digit = '5';
            char symbol = '#';

            // Char methods and static helpers
            bool isLetter = char.IsLetter(letter); // true
            bool isDigit = char.IsDigit(digit);    // true
            bool isWhiteSpace = char.IsWhiteSpace(' '); // true
            char lower = char.ToLower(letter);     // 'a'
            char upper = char.ToUpper('b');        // 'B'

            // Printing values
            Console.WriteLine($"letter: {letter}");
            Console.WriteLine($"digit: {digit}");
            Console.WriteLine($"symbol: {symbol}");
            Console.WriteLine($"IsLetter: {isLetter}");
            Console.WriteLine($"IsDigit: {isDigit}");
            Console.WriteLine($"IsWhiteSpace: {isWhiteSpace}");
            Console.WriteLine($"ToLower: {lower}");
            Console.WriteLine($"ToUpper: {upper}");

            // Char to string
            string letterString = letter.ToString();
            Console.WriteLine($"Char to string: {letterString}");
        }
    }
}

