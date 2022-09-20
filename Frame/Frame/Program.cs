using System;

namespace Frame
{
    class Program
    {
        static void Main()
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("Game Over!");
        }

        static void WriteTextWithBorder(string text)
        {
            var hyphenLine = "";
            for (int i = 0; i < text.Length + 2; i++)
            {
                hyphenLine += "-";
            }
            Console.WriteLine($"+{hyphenLine}+");
            Console.WriteLine($"| {text} |");
            Console.WriteLine($"+{hyphenLine}+");
        }
    }
}
