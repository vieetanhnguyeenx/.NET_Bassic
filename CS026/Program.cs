using System;
using System.Collections.Generic;

namespace CS026
{
    class Program
    {

        class Product
        {
            public string Name {set; get;}
            public double Price {set; get;}
            public int ID {set; get;}
            public string? Origin {set; get;}
        }

        static void Main(string[] args)
        {
             List<int> ds1 = new List<int>() { 7, 8, 9, 1, 6, 4, 5 };
             ds1.Add(1);
             ds1.Add(2);
             ds1.AddRange(new int[] {3, 4, 5});
             ds1.Insert(0, 10);
             Console.WriteLine(ds1.Count());

            // // Console.WriteLine(ds1[0]);
            // // foreach (var i in ds1)
            // // {
            // //     Console.WriteLine(i);
            // // }
            // //List<string> ds2;
            // var n = ds1.FindAll(
            //    (int x) =>
            //    {
            //        return x % 2 == 0;
            //    }
            // );
            // foreach (var i in n)
            // {
            //     Console.WriteLine(i);
            // }
            
            // List<Product> products = new List<Product>() {
            //     new Product() {
            //         Name = "AIphone X",
            //         Price = 1000,
            //         Origin = "China",
            //         ID = 1
            //     },

            //     new Product() {
            //         Name = "DSamsung",
            //         Price = 900,
            //         Origin = "Korean",
            //         ID = 2
            //     },

            //     new Product() {
            //         Name = "CSony",
            //         Price = 1100,
            //         Origin = "Japan",
            //         ID = 3
            //     },

            //     new Product() {
            //         Name = "BNokia",
            //         Price = 800,
            //         Origin = "German",
            //         ID = 4
            //     }
            // };


            // var n = products.Find(
            //     (Product p) =>
            //     {
            //         return p.Origin == "Japan";
            //     }
            // );
            // if (n != null) {
            //     Console.WriteLine($"Name: {n.Name} \nPrice: {n.Price} \nOrigin: {n.Origin} \nID: {n.ID}");
            // }

            // var n1 = products.FindAll(
            //     (Product p) =>
            //     {
            //         return p.Price > 800;
            //     }
            // );

            // foreach (var i in n1)
            // {
            //     Console.WriteLine($"Name: {i.Name} \nPrice: {i.Price} \nOrigin: {i.Origin} \nID: {i.ID} \n");
            // }

            // products.Sort(
            //     (Product p1, Product p2) =>
            //     {
            //         if (p1.Name.CompareTo(p2.Name) > 0) {
            //             return 1;
            //         } else if(p1.Name.CompareTo(p2.Name) == 0) {
            //             return 0;
            //         } else
            //         {
            //             return -1;
            //         }
                    

            //     }
            // );

            // products.Sort(
            //     (p1, p2) => 
            //     {
            //         if (p1.Price == p2.Price) return 0;
            //         if (p1.Price > p2.Price) return 1;
            //         return -1;
            //     }
            // );

            // foreach (var i in products)
            // {
            //     Console.WriteLine($"Name: {i.Name} \nPrice: {i.Price} \nOrigin: {i.Origin} \nID: {i.ID} \n");
            // }
            /*
            SortedList<string, Product> products = new SortedList<string, Product>();
            products["sanpham1"] = new Product() {Name = "Iphone", Price = 1000, Origin = "China"};
            products["sanpham2"] = new Product() {Name = "Samsung", Price = 900, Origin = "China"};
            products.Add("sanpham3", new Product() {Name = "Nokia", Price = 1100, Origin = "China"});

            var p = products["sanpham1"];
            Console.WriteLine(p.Name);

            var keys = products.Keys;
            var values = products.Values;

            foreach (var k in keys)
            {
                var product = products[k];
                Console.WriteLine($"Name: {product.Name} \nPrice: {product.Price} \nOrigin: {product.Origin} \nID: {product.ID} \n");
            }
            */
        }
    }
}