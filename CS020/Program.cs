using System;

namespace CS020
{

    public delegate void ShowLog(string message);



    class Program
    {
        static void Info(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static void Warning(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        //delegate int Kieu1();

        static void Tong(int a, int b, ShowLog log)
        {
            int kq = a + b;
            log?.Invoke($"Tong hai {a} + {b} = {kq}");
        }
        static int Hieu(int a, int b) => a - b;
        static void Main(string[] args)
        {
            //Action la void
            // Action action; // delegate void Kieu();
            // Action<string, int> action1; // delegate void Kieu(string s, int i);

            // Action<string> action2; // delegate void Kieu(string s);
            // action2 = Warning;
            // action2 += Info;
            // action2?.Invoke("Hello");

            //Func co tra ve
            //Kieu1 f1;
            //Func<int> f1; // delegate int Kieu();
            //Func<string, double, string> f2; // delegate string Kieu(string, double);
            ShowLog sl = Info;
            Tong(5, 10, Info);
            
        }
    }
}
