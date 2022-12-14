using System;

namespace CS022_Envent
{

    /*
        publisher -> class - phat di su kien
        subsriber -> class - nhan su kien
    */

    class DuLieuNhap : EventArgs
    {
        public int data {set; get;}
        public DuLieuNhap(int x) => data = x;

        public int getData()
        {
            return this.data;
        }
    }
    //publisher
    class UserInput
    {

        // delegate void Kieu(object, EnventArgs)
        public event EventHandler? sukiennhapso;
        public void Input()
        {
            do
            {
                Console.Write("Nhap vao so nguyen: ");
                int i = Convert.ToInt32(Console.ReadLine());
                sukiennhapso?.Invoke(this, new DuLieuNhap(i));
            } while (true);

        }

        public EventHandler? getEnvent()
        {
            return this.sukiennhapso;
        }

        //int age = Int32.Parse(Console.ReadLine());
    }

    class TinhBP
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += BinhPhuong;
        }

        public void Unsub(UserInput input)
        {
            input.sukiennhapso -= BinhPhuong;
        }
        public void BinhPhuong(object? sender, EventArgs e)
        {
            DuLieuNhap dl = (DuLieuNhap)e;
            int x = dl.data;
            Console.WriteLine($"Binh Phuong cua {x} la: {x * x}");
        }
    }
    //
    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += Can;
        }

        public void Unsub(UserInput input)
        {
            input.sukiennhapso -= Can;
        }
        public void Can(object? sender, EventArgs e)
        {
            DuLieuNhap dl = (DuLieuNhap)e;
            int i = dl.data;
            Console.WriteLine($"Can bac hai cua {i} la {Math.Sqrt(i)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            TinhCan tc = new TinhCan();
            tc.Sub(ui);
            TinhBP bp = new TinhBP();
            bp.Sub(ui);

            
            ui.Input();
        }
    }
}
