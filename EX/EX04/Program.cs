using System;

namespace EX04
{

    class Data
    {
        public int a {set; get;}
        public int b {set; get;}
        public Data(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
    }

    class EventData : EventArgs
    {
        public Data data {set; get;}
        public EventData(Data data)
        {
            this.data = data;
        }

        public Data getData()
        {
            return this.data;
        }
    }

    class UserInput
    {
        //delegate
        public event EventHandler? inputEvent;

        public void Input()
        {
            do
            {
                Console.Write("Enter a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                inputEvent?.Invoke(this, new EventData(new Data(a, b)));

            } while (true);
        }
    }

    class Compare
    {
        public void Sub(UserInput input)
        {
            input.inputEvent += CompareTwoNumber;
        }

        public void CompareTwoNumber(object? sender, EventArgs e)
        {
            EventData eData = (EventData) e;
            Data data = eData.data;
            int a = data.a;
            int b = data.b;
            if (a == b) {
                Console.WriteLine($"Equal: {a} == {b}");
            } else if (a > b)
            {
                Console.WriteLine($"{a} > {b}");
            } else
            {
                Console.WriteLine($"{a} < {b}");
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            Compare c = new Compare();
            c.Sub(ui);

            ui.Input();
        }
    }
}
