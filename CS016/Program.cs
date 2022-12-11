using System;

namespace CS016
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 14;
            string abc = "abc";
            string xyz = "xyz";
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"abc = {abc}, xyz = {xyz}");
            Swap<int>(ref a, ref b);
            Swap<string>(ref abc, ref xyz);
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"abc = {abc}, xyz = {xyz}");

            Product<int, string> sanpham1 = new Product<int, string>();
            sanpham1.setId(1);
            sanpham1.setName("Iphone");
            sanpham1.showInfo();

        }

        static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }

        static void Swap(ref float x, ref float y)
        {
            float t = x;
            x = y;
            y = t;
        }
    }

    class Product<A, B>
    {
        private A? id;
        private B? name;
        public void setId(A id)
        {
            this.id = id;
        }

        public void setName(B name)
        {
            this.name = name;
        }

        public void showInfo()
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }
    }
}
