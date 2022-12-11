using static System.Console;
using MyNameSpace;
using XYZ = MyNameSpace.Abc;
namespace CS015
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class1.xinChao();
            // XYZ.Class1.xinChao();
            // WriteLine("hello");

            Sanpham.Product product = new Sanpham.Product();
            product.name = "Ipad";
            product.price = 1000;
            product.description = "This is Ipad";

            WriteLine(product.getInfo());
            product.Abc();
        }
    }
}
