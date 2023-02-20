using System;

namespace CS_Envent_RE
{

    /*
     * Publisher -> class phat di su kien
     * Subsriber -> class nhan su kien
     */

    public delegate void SuKienNhapSo(int x);

    class DuLieuNhap : EventArgs
    {
        public int data { get; set; }
        public DuLieuNhap(int x) { data = x; }


        class UserInput
        {
            public event EventHandler suKienNhapSo; // ~ delegate void Kieu(object? sender, EventArgs)
            public void Input()
            {
                do
                {
                    Console.WriteLine("Nhap Vao So Nguyen: ");
                    string s = Console.ReadLine();
                    int i = Int32.Parse(s);
                    suKienNhapSo?.Invoke(this, new DuLieuNhap(i));
                } while (true);

            }
        }
        class TinhBinhPhuong
        {
            public void Sub(UserInput input)
            {
                input.suKienNhapSo += BinhPhuong;
            }
            public void BinhPhuong(object? sender, EventArgs e)
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                Console.WriteLine($"Can bac hai cua {duLieuNhap.data} la {Math.Pow(duLieuNhap.data, 2)}");
            }
            public void UnSub(UserInput input)
            {
                input.suKienNhapSo -= BinhPhuong;
            }
        }

        class TinhCan
        {
            public void Sub(UserInput input)
            {
                input.suKienNhapSo += Can;
            }
            public void Can(object? sender, EventArgs e)
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)(e);
                Console.WriteLine($"Can bac hai cua {duLieuNhap.data} la {Math.Sqrt(duLieuNhap.data)}");
            }

            public void UnSub(UserInput input)
            {
                input.suKienNhapSo -= Can;
            }
        }
        class Program
        {


            static void Main(string[] args)
            {
                UserInput userInput = new UserInput();

                userInput.suKienNhapSo += (sender, e) =>
                {
                    DuLieuNhap duLieuNhap = (DuLieuNhap)e;

                    Console.WriteLine($"Ban vua nhap so {duLieuNhap.data}");
                };
                TinhCan tinhCan = new TinhCan();
                tinhCan.Sub(userInput);

                TinhBinhPhuong tinhBinhPhuong = new TinhBinhPhuong();
                tinhBinhPhuong.Sub(userInput);


                userInput.Input();
            }
        }
    }
}