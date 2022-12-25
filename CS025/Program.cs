using System;
using static System.Console;
using MyException;

namespace CS025
{
    class Program
    {

        static void Register(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                //Exception e = new Exception("Ten phai khac rong");
                //throw e;
                throw new NameEmptyException();
            }
            if (age < 18 || age > 100 )
            {
                //throw new Exception("Tuoi phai >= 18 va <= 100");
                throw new AgeException(age);
            }
            Console.WriteLine($"Xin chao {name} ({age})");
        }
        static void Main(string[] args)
        {
            /*
            int a = 5;
            int b = 4;
            int[] i = { 1, 2 };
            try
            {
                var c = a / b;      // phat sinh doi tuong thuoc lop Exception, ke thua Exception
                Console.WriteLine(c);

                int x = i[6];
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine(e1.Message); // noi dung bi loi
                Console.WriteLine(e1.StackTrace); // thong tin loi o dau
                WriteLine(e1.GetType().Name); // lay kieu va ten 
                Console.WriteLine("Phep chia co loi");
            }
            catch (IndexOutOfRangeException e2)
            {
                Console.WriteLine(e2.Message); // noi dung bi loi
                Console.WriteLine(e2.StackTrace); // thong tin loi o dau
                WriteLine(e2.GetType().Name); // lay kieu va ten 
                Console.WriteLine($"Khong duoc truy cap ngoai bien {i.Length}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // noi dung bi loi
                Console.WriteLine(e.StackTrace); // thong tin loi o dau
                WriteLine(e.GetType().Name); // lay kieu va ten 
                Console.WriteLine("Co loi xay ra");
            }
            WriteLine("Ket thuc");
            */

            /*
            string path = "1.txt";
            try
            {
                string s = File.ReadAllText(path);
                Console.WriteLine(s);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
                Console.WriteLine("File khong ton tai");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                Console.WriteLine("Duong dan phai khac null");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine("co loi xay ra");
            }
            */
            try
            {
                Register("NVA", 192);
            }
            catch (NameEmptyException nee)
            {
                Console.WriteLine(nee.Message);
            }
            catch (AgeException ae)
            {
                Console.WriteLine(ae.Message);
                ae.Detail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().Name);
            }


            WriteLine("Ket thuc");
        }
    }
}