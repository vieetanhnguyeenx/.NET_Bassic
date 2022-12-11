using System;
namespace Sanpham
{
    public partial class Product
    {
        public string? description {set; get;}

        public void Abc()
        {
            string s = getInfo();
            Console.WriteLine($"day la san phan: {s}");
        }
    }
}