using System;
using System.Collections.Generic;

namespace CS026_2
{

    class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }

        public string Origin { get; set; }

        public override string? ToString()
        {
            return Name + "\t" + Id + "\t" + Price + "\t" + Origin;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> ds1 = new List<int>() { 7, 8, 9 };
            ds1.Add(1);
            ds1.Add(9);
            ds1.AddRange(new int[] { 3, 4, 5 });
            ds1.Insert(0, 10);
            var n = ds1.FindAll((int x) =>
            {
                return x % 3 == 0;
            }
                );
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
            */


            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Iphone X",
                Origin = "China",
                Price = 1000
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Samsung",
                Origin = "Kr",
                Price = 900
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Sony",
                Origin = "JP",
                Price = 1100
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Nokia",
                Origin = "China",
                Price = 800
            });
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }
            /*
            var rs = products.FindAll(p => p.Origin.ToLower().Equals("China".ToLower()));
            Console.WriteLine(rs.Count);
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }
            */
            Console.WriteLine();
            products.Sort(
                (p1, p2) =>
                {
                    if (p1.Price - p2.Price > 0) return 1;
                    else if (p1.Price - p2.Price == 0) return 0;
                    else return -1;
                });
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
