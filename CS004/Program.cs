using System;
namespace CS004
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());

            double b;
            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());

            char c;
            c = Console.ReadKey().KeyChar;

            switch (c)
            {
                case '1':
                    Console.WriteLine($"Tong {a} + {b} = {a + b}");
                break;
                case '2':
                    Console.WriteLine($"Hieu {a} - {b} = {a - b}");
                break;
                case '3':
                    Console.WriteLine($"Tich {a} * {b} = {a * b}");
                break;
                case '4':
                    Console.WriteLine($"Thuong {a} / {b} = {a / b}");
                break;
                case '5':
                    Console.WriteLine($"Du {a} % {b} = {a % b}");
                break;                
            }
        }

    }

}
