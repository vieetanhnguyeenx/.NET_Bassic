using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the string: ");
            Console.ResetColor();
            string? s = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            if (s != null)
            {
                Console.WriteLine(s);
            }
            Console.ResetColor();
        }
    }
}
