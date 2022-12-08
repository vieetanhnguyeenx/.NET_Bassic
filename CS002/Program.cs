namespace CS002
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kieu_du_lieu Ten_bien
            Ten_bien:
                - a-z A-Z
                - 0 - 9
                - _
                - Khong bat dau bang so
            */

            // String studentName = "a";
            // int studentAge = 100;
            // Console.Clear();
            // Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // Console.Title = "Vi du su dung Console";
            // Console.WriteLine("name: " + studentName);
            // Console.ResetColor();
            // Console.ReadKey();
            // Console.BackgroundColor = ConsoleColor.DarkRed;
            // Console.WriteLine("age: " + studentAge);
            // Console.ResetColor();

            // string name;
            // name = Console.ReadLine();
            // Console.WriteLine("user name: " + name);

            double a, b;
            string sinput;
            

            Console.WriteLine("Enter a:");
            sinput = Console.ReadLine();
            a = double.Parse(sinput);

            Console.WriteLine("Enter b:");
            sinput = Console.ReadLine();
            b = double.Parse(sinput);

            double sum = a + b;
            Console.WriteLine( a + " + " + b +" = " + sum );
            Console.WriteLine("{0} + {1} = {3}", a, b, sum);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Bye");
        }
    }
}