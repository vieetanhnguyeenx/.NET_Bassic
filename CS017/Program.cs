using System;
using System.Collections.Generic;
using System.Linq;
namespace CS017
{
    class Program
    {
        // Annonymous - kieu du lieu vo danh
        // Object - thuoc tinh - chi doc
        // new {thuoctinh = gia tri, thuoctinh2 = gia tri2}

        class SinhVien
        {
            public string? name {set; get;}
            public int namSinh {set; get;}
            public string? noiSinh {set; get;}
        }
        static void Main(string[] args)
        {
           List<SinhVien> list = new List<SinhVien>() {
                new SinhVien() {name = "Nam", namSinh = 2000, noiSinh = "Binh Duong"},
                new SinhVien() {name = "Dan", namSinh = 2001, noiSinh = "Binh Duong"},
                new SinhVien() {name = "A", namSinh = 2002, noiSinh = "Binh Duong"},
                new SinhVien() {name = "Long", namSinh = 2000, noiSinh = "Binh Duong"}
           };

           var ketQua = from sv in list
                        where sv.noiSinh.ToLower().Equals("binh duong")
                        select new {
                            Ten = sv.name,
                            Ns = sv.noiSinh
                        };

            foreach (var i in ketQua)
            {
                Console.WriteLine(i.Ten + "\t" + i.Ns);
            }
        }
    }
}
