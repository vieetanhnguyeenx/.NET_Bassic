using System;

namespace CS009
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello(fistName:"Nguyen Van", lastName:"A");

            double result;
            result = CS006_Caculate.Caculate.add(b:100, a:2311);

            Console.WriteLine(result);
        }


        public static void sayHello(string lastName, string fistName ) 
        {
            Console.WriteLine("Hello and wellcome back " + lastName + " " + fistName);
        }


        public static double add(double a, double b)
        {
            return a + b;
        }

        public static double sub(double a, double b)
        {
            return a - b;
        }

        public static double mul(double a, double b)
        {
            return a * b;
        }

        public static double div(double a, double b)
        {
            return a / b;
        }
    }
}
