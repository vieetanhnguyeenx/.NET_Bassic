using System;

namespace EX3
{

    class Data
    {
        public Data(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int a { set; get; }
        public int b { set; get; }

    }

    class DataEnvent : EventArgs
    {
        public Data data { set; get; }
        public DataEnvent(Data data)
        {
            this.data = data;
        }

    }

    class UserInput
    {
        public event EventHandler? myEvent;
        public void Input()
        {
            do
            {
                Console.WriteLine("Enter a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Data data = new Data(a, b);
                myEvent?.Invoke(this, new DataEnvent(data));

            } while (true);
        }
    }

    class Sum
    {

        public void Sub(UserInput input)
        {
            input.myEvent += CalSum;
        }
        public void CalSum(object? sender, EventArgs e)
        {
            DataEnvent de = (DataEnvent)e;
            Data? data = de.data;
            int a = data.a;
            int b = data.b;
            Console.WriteLine($"Sum {a} + {b} = {a + b}");
        }
    }

    class Substract
    {

        public void Sub(UserInput input)
        {
            input.myEvent += CalSub;
        }
        public void CalSub(object? sender, EventArgs e)
        {
            DataEnvent de = (DataEnvent)e;
            Data? data = de.data;
            int a = data.a;
            int b = data.b;
            Console.WriteLine($"Sum {a} - {b} = {a - b}");
        }
    }

    class Multiple
    {

        public void Sub(UserInput input)
        {
            input.myEvent += CalMul;
        }
        public void CalMul(object? sender, EventArgs e)
        {
            DataEnvent de = (DataEnvent)e;
            Data? data = de.data;
            int a = data.a;
            int b = data.b;
            Console.WriteLine($"Sum {a} * {b} = {a * b}");
        }
    }

    class Division
    {

        public void Sub(UserInput input)
        {
            input.myEvent += CalDiv;
        }
        public void CalDiv(object? sender, EventArgs e)
        {
            DataEnvent de = (DataEnvent)e;
            Data? data = de.data;
            double a = (double)data.a;
            double b = (double)data.b;
            Console.WriteLine($"Sum {a} / {b} = {a / b}");
        }
    }

    class Modulo
    {

        public void Sub(UserInput input)
        {
            input.myEvent += CalMo;
        }
        public void CalMo(object? sender, EventArgs e)
        {
            DataEnvent de = (DataEnvent)e;
            Data? data = de.data;
            int a = data.a;
            int b = data.b;
            Console.WriteLine($"Sum {a} % {b} = {a % b}");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            Sum s = new Sum();
            s.Sub(ui);
            Substract sub = new Substract();
            sub.Sub(ui);
            Multiple m = new Multiple();
            m.Sub(ui);
            Division div = new Division();
            div.Sub(ui);
            Modulo mo = new Modulo();
            mo.Sub(ui);
            ui.Input();
        }
    }
}
