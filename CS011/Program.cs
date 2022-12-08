using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace CS011
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string name = "NVA";
            int dob = 2022;
            bool gender = true;

            string hello = $@"
                Name: {name, 10};
                DOB:  {dob, 10};
                Gender: {gender, 8};
            ";
            Console.WriteLine(hello);
            */

            string thongbao = "NVA, xin chao cac ban";
            /*
            for (int i = 0; i < thongbao.Length; i++)
            {
                char c = thongbao[i];
                Console.WriteLine($"Index{i,3} is: {c}");
            }
            */

            foreach (var i in thongbao)
            {
                Console.WriteLine(i);
            }

            string[] subString = { "hello", "world", "hello", "NVA" };
            string s = string.Join(" ", subString);
            Console.WriteLine(s);
            int t = s.IndexOf("NVA");
            Console.WriteLine(t);


            String text = @"Đây là địa chỉ
            email userabcguest@xuanthulab.net.vn và
            xyz@gmail.com cần trích xuất";
            String pattern = @"(([^\s.]+)@((.[^\s]+)(\..[^\s]+)))";

            Regex rx = new Regex(pattern);

            // Tìm kiếm.
            MatchCollection matches = rx.Matches(text);
            // In thông báo tìm kiếm.
            Console.WriteLine("Tìm thấy {0} email trong:\n\n  {1}\n\n",
                            matches.Count,
                            text);
            ArrayLis matches.ToList()
        }
    }
}
