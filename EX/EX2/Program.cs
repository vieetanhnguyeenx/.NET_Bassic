using System;

namespace EX2
{
    public class MyEnventArgs : EventArgs
    {
        public MyEnventArgs(int data)
        {
            this.data = data;
        }
        private int data { set; get; }

        public int getData()
        {
            return this.data;
        }
    }
    class NumberHandler
    {
        public event EventHandler? myEvent;

        public void Input()
        {
            do
            {
                Console.WriteLine("Enter a Number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                myEvent?.Invoke(this, new MyEnventArgs(x));
            } while (true);
        }

    }

    class EvenOddDetector
    {
        public void Sub(NumberHandler input)
        {
            input.myEvent += EvenOrOdd;
        }

        public void EvenOrOdd(object? sender, EventArgs e)
        {
            MyEnventArgs me = (MyEnventArgs)e;
            int x = me.getData();
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is Enven number");
            }
            else
            {
                Console.WriteLine($"{x} is Odd number");
            }
        }
    }

    class DivisibleForThree
    {
        public void Sub(NumberHandler input)
        {
            input.myEvent += IsDivisibleForThree;
        }

        public void IsDivisibleForThree(object? sender, EventArgs e)
        {
            MyEnventArgs me = (MyEnventArgs)e;
            int x = me.getData();
            if (x % 3 == 0)
            {
                Console.WriteLine($"{x} is divisible for three");
            }
            else
            {
                Console.WriteLine($"{x} is not divisible for three");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberHandler nh = new NumberHandler();
            EvenOddDetector eod = new EvenOddDetector();
            eod.Sub(nh);
            DivisibleForThree dt = new DivisibleForThree();
            dt.Sub(nh);
            
            nh.Input();
        }
    }
}
