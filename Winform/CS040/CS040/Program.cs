using CS040.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CS040
{
    class Program
    {
        static void CreateDataBase()
        {
            using var dbcontext = new ShopContext();
            string dbName = dbcontext.Database.GetDbConnection().Database;

            var kq = dbcontext.Database.EnsureCreated();

            if (kq)
            {
                Console.WriteLine($"Tao co so du lieu {dbName} thanh cong");
            }
            else
            {
                Console.WriteLine($"Tao co so du lieu {dbName} that bai");
            }
            //Console.WriteLine(dbName);
        }

        static void DropDataBase()
        {
            using var dbcontext = new ShopContext();
            string dbName = dbcontext.Database.GetDbConnection().Database;

            var kq = dbcontext.Database.EnsureDeleted();

            if (kq)
            {
                Console.WriteLine($"Xoa co so du lieu {dbName} thanh cong");
            }
            else
            {
                Console.WriteLine($"Xoa co so du lieu {dbName} that bai");
            }
            //Console.WriteLine(dbName);
        }

        //static void InsertProduct()
        //{
        //    using var dbcontext = new ProductDBContext();
        //    /*
        //     *  B1: Tạo dối tượng Model (Prodcut)
        //     *  B2: Sử dụng add, addAsyn
        //     *  B3: Sử dụng SaveChange
        //     */
        //    // cách chèn 1 sản phẩm
        //    //Product p1 = new Product();
        //    //p1.ProductName = "San Pham 2";
        //    //p1.Provider = "Cong ty 2";
        //    //dbcontext.Add(p1);

        //    //chèn nhiều sản phẩm AddRange()
        //    List<Product> products = new List<Product> {
        //        new Product() {ProductName = "San Pham 3", Provider = "Cong ty A"} ,
        //        new Product() {ProductName = "San Pham 4", Provider = "Cong ty B"} ,
        //        new Product() {ProductName = "San Pham 5", Provider = "Cong ty C"} ,
        //    };

        //    dbcontext.AddRange(products);
        //    int x = dbcontext.SaveChanges();
        //    Console.WriteLine($"Da chen {x} du lieu");
        //}

        //static void ReadProduct()
        //{
        //    using var dbcontext = new ProductDBContext();
        //    //linq 
        //    dbcontext.products.ToList().ForEach(p => { p.PrintInfo(); });

        //    //var query = from product in dbcontext.products
        //    //            where product.ProductId >= 5
        //    //            select product;
        //    //query.ToList().ForEach(x => x.PrintInfo());

        //    //var query2 = from product in dbcontext.products
        //    //             where product.Provider.Contains("Cong Ty")
        //    //             orderby product.ProductId descending
        //    //             select product;
        //    //query2.ToList().ForEach(x => x.PrintInfo());
        //}

        //static void RenameProduct(int id, string newName)
        //{
        //    using var dbcontext = new ProductDBContext();
        //    Product? productToSet = (from product in dbcontext.products
        //                             where product.ProductId == id
        //                             select product).SingleOrDefault();
        //    if (productToSet != null)
        //    {
        //        productToSet.ProductName = newName;
        //        int x = dbcontext.SaveChanges();
        //        Console.WriteLine(x);
        //    }
        //}

        //static void deleteProductById(int id)
        //{
        //    using var dbcontext = new ProductDBContext();
        //    Product? productToSet = (from product in dbcontext.products
        //                             where product.ProductId == id
        //                             select product).SingleOrDefault();
        //    if (productToSet != null)
        //    {
        //        dbcontext.products.Remove(productToSet);
        //        int x = dbcontext.SaveChanges();
        //        Console.WriteLine(x);
        //    }
        //}

        static void InsertData()
        {
            using var dbcontext = new ShopContext();
            //Category c1 = new Category()
            //{
            //    Name = "Điện thoại",
            //    Description = "Các loại điện thoại"
            //};
            //Category c2 = new Category()
            //{
            //    Name = "Đồ uống",
            //    Description = "Các loại đồ uống"
            //};
            //dbcontext.Add(c1);
            //dbcontext.Add(c2);

            //var c1 = (from c in dbcontext.categories
            //          where c.CategoryId == 1
            //          select c).FirstOrDefault();
            //dbcontext.Add(new Product()
            //{
            //    Name = "Iphone 14",
            //    Price = 1321.1,
            //    Category = c1
            //});

            var c1 = (from c in dbcontext.categories
                      where c.CategoryId == 1
                      select c).SingleOrDefault();
            dbcontext.Add(new Product()
            {
                Name = "Cuoc doi111111111111111",
                Price = 12.222,
                Category = c1
            });
            dbcontext.Add(new Product()
            {
                Name = "Quan dui1111111111111111111",
                Price = 11.2,
                Category = c1
            });

            dbcontext.SaveChanges();
        }

        static void Main(string[] args)
        {
            // database - sql : data01
            // --product
            //DropDataBase();
            //CreateDataBase();
            //InsertProduct();
            //RenameProduct(4, "Cuoc doi buon");
            //deleteProductById(3);
            //ReadProduct();

            //InsertData();
            string s = new string("hello");
            int alo = new int();
            alo = alo + 1;
            Console.WriteLine(alo);
            //var DbContext = new ShopContext();
            //var product = (from p in DbContext.products
            //               where p.ProductId == 3
            //               select p).FirstOrDefault();

            //// Trong product có 1 đối tượng liên quan đên product là category nếu không thêm câu lệnh ta sẽ không lấy dc category
            //// Ta sử dung đối tượng Entry để lấy dữ liệu liên quan vì khi chạy đối tượng này giám sát các try vấn và thay đổi
            //var e = DbContext.Entry(product);
            ////Lấy reference từ entry và chỉ ra thuộc tính liên quan cần lấy vd Category
            //e.Reference(p => p.Category).Load();


            //if (product != null)
            //{
            //    product.PrintInfo();
            //}
            //if (product.Category == null)
            //{
            //    Console.WriteLine("null");
            //}

            //var c1 = (from c in DbContext.categories
            //          where c.CategoryId == 1
            //          select c).SingleOrDefault();

            //var e = DbContext.Entry(c1);
            //e.Collection(c => c.Products).Load();

            //if (c1.Products != null)
            //{
            //    Console.WriteLine(c1.Products.ToList().Count());
            //    c1.Products.ToList().ForEach(product => product.PrintInfo());
            //}
            //else
            //{
            //    Console.WriteLine("Null");
            //}

            //using var dbcontext = new ShopContext();
            //var products = (from p in dbcontext.products
            //                select p).ToList();
            //foreach (var item in products)
            //{
            //    item.Category = ((Category)(from c in dbcontext.categories
            //                                where c.CategoryId == item.CategoryId
            //                                select c));
            //}

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.Name + item.Category.Name);
            //}

        }
    }
}

