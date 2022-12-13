using System;

namespace CS019
{

    abstract class Product
    {
        protected double? Price { set; get; }

        public abstract void ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;


        public override void ProductInfo()
        {
            Console.WriteLine("This is Iphone");
            Console.WriteLine($"Product Price {Price}");
        }
    }

    // interface
    interface IHinhHoc
    {
        public double TinhChuVi();

        public double TinhDienTich();
    }

    class HinhChuNhat : IHinhHoc
    {
        public HinhChuNhat()
        {
        }

        private double a {set; get;}
        private double b {set; get;}

        public HinhChuNhat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double TinhChuVi()
        {
            return 2 * (a + b);
        }

        public double TinhDienTich()
        {
            return a * b;
        }
    }

    class HinhTron : IHinhHoc
    {
        public HinhTron()
        {
        }

        public double r {set; get;}

        public HinhTron(double r)
        {
            this.r = r;
        }

        public double TinhChuVi()
        {
            return 2 * r * Math.PI;
        }

        public double TinhDienTich()
        {
            return Math.PI * r * r;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat(a: 4, b: 5);
            Console.WriteLine($"Dien Tich: {hcn.TinhDienTich()}, Chu Vi: {hcn.TinhChuVi()}");
            HinhTron ht = new HinhTron(1);
            Console.WriteLine($"Dien Tich: {ht.TinhDienTich()}, Chu Vi: {ht.TinhChuVi()}");            
        }
    }
}
