using System;
using System.Linq;
using MyLib;
namespace CS023
{
    // extension method
    // lop tinh static

    // static class Abc
    // {
    //     public static void Print(this string s, ConsoleColor color)
    //     {
    //         Console.ForegroundColor = color;
    //         Console.WriteLine(s);
    //         Console.ResetColor();
    //     }
    // }
    class Program
    {

        static void Main(string[] args)
        {
            // string s = "xin chao cac ban";
            // s.Print(ConsoleColor.Black);

            double a = 2.5;
            Console.WriteLine(a.BinhPhuong());
            Console.WriteLine(a.CanBacHai());
            Console.WriteLine(a.Sin());
            Console.WriteLine(a.Cos());
        }
    }
}
