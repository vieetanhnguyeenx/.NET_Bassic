using System;

namespace CS008 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // string sv1 = "Nguyen Van A";
            // string sv2 = "Nguyen Van B";
            // string sv3 = "Nguyen Van C";

            // Console.WriteLine(sv1);
            // Console.WriteLine(sv2);
            // Console.WriteLine(sv3);

            string[] ds = new string[3];
            ds[0] = "Nguyen Van A";
            ds[1] = "Nguyen Van B";
            ds[2] = "Nguyen Van D";

            foreach (var i in ds)
            {
                Console.WriteLine(i);
            }
        }
    }
}
