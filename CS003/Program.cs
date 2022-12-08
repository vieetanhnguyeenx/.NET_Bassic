using System;
class CS003
{
    class Program
    {
        static void Main(string[] args)
        {
            // // + - * / %
            // double a = 5;
            // double b = 4;

            // Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            // Console.WriteLine($"{a} - {b} = {a - b}");
            // Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            // Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            // Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
            // Console.Beep();

            // int a;
            // Console.WriteLine("Nhap so nguyen a:");
            // a = int.Parse(Console.ReadLine());

            // if (a % 2 == 0)
            // {
            //     Console.WriteLine($"so {a} la so chan");
            // }
            // else
            // {
            //     Console.WriteLine($"so {a} la so le");
            // }

            /*
            8 - 10 gioi
            6.5 - 8 kha
            5.0 - 6.5 trung binh
            0 - 5.0 yeu
            */
            double aMark;
            Console.Write("Enter your avenge mark: ");
            aMark = double.Parse(Console.ReadLine());

            if (aMark >= 8 && aMark <= 10)
            {
                Console.WriteLine("Hoc luc gioi");
            }
            else if (aMark >= 6.5 && aMark < 8)
            {
                Console.WriteLine("Hoc luc kha");
            }
            else if (aMark >= 5 && aMark < 6.5) 
            {
                Console.WriteLine("Hoc luc trung binh");
            }
            else
            {
                Console.WriteLine("Hoc luc yeu");
            }
        }
    }
}
