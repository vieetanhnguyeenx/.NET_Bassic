using System;

namespace CS021
{
    class Program
    {

        /*
        Lambda - Anonymous function
        Cach khai bao
        1,
        (int a, int b) => 
        {
            cac_bieu_thuc;
            return bieu thuc tra ve;
        }
        2, 
        (tham so) => bieu_thuc
        */
        static void Main(string[] args)
        {

            // Action<string> thongBao = (string s) => Console.WriteLine(s);
            // Action thongBao2 = () => Console.WriteLine("Hello World!");
            // // (int a, int b) => 
            // // {
            // //     int kq = a + b;
            // //     return kq;
            // // };

            // thongBao?.Invoke("xinchao");
            // thongBao2?.Invoke();

            // Action<string, string> wellcome;
            // wellcome = (string msg, string name) => Console.WriteLine(msg + " " + name);
            // wellcome?.Invoke("I Love You So Much","NVA");
            // wellcome?.Invoke("I Love You Too","NVA");

            // wellcome = (string msg, string name) =>
            // {
            //     Console.ForegroundColor = ConsoleColor.DarkRed;
            //     Console.WriteLine(msg + " " + name);
            //     Console.ResetColor();
            // };
            // wellcome?.Invoke("I Love You So Much","NVA");
            // wellcome?.Invoke("I Love You Too","NVA");

            // Func<int, int, int> calculate;
            // calculate = (int a, int b) =>
            // {
            //     return a + b;
            // };

            // Console.WriteLine(calculate.Invoke(3, 8));

            int[] array = { 2, 4, 64, 78, 87, 99, 1 };

            // Func<int, double> r = (int x) => 
            // {
            //     return Math.Sqrt(x);
            // };
            // var result = array.Select<int, double>((int x) => {
            //     return Math.Sqrt(x);
            // });
            // foreach (var re in result)
            // {
            //     Console.WriteLine(re);
            // }

            // array.ToList().ForEach((int x) =>
            // {
            //     if (x % 2 != 0)
            //     {
            //         Console.WriteLine(x);
            //     }
            // });

            var kq = array.Where((int x) =>
            {
                if (x % 4 == 0)
                {
                    return true;
                } else
                {
                    return false;
                }

            });

            foreach (var r in kq)
            {
                Console.WriteLine(r);
            }
        }
    }
}
