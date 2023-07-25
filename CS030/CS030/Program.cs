using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace LinqExample
{
    /*
     * Select
     * Where
     * SelectMany
     * Min, Max, Sum, Avarage
     * Join
     * GroupJoin
     * Take
     * Skip
     */
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // các màu sắc
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }

    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }

        public override string? ToString()
        {
            return ID + " " + Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            //var query = from p in products where p.Price == 400 select p;
            //var queryName = from p in products where p.Name.ToLower().Contains("a") select p;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in queryName)
            //{
            //    Console.WriteLine(item);
            //}


            /* 
                Select :
                Dùng khi lấy ra 1 phần của danh sách VD chỉ lấy name hay price của product
            */
            Console.WriteLine();
            Console.WriteLine("Select price");
            var kqSelect01 = products.Select((p) =>
            {
                return p.Price; // return giá trị nào đó
            });
            foreach (var item in kqSelect01)
            {
                Console.WriteLine(item);
            }
            /*
             Select price
                400
                400
                500
                200
                300
                500
                600
             */


            // Có thể viết dạng truy vấn
            Console.WriteLine("Select price query");
            var kqSelect02 = from p in products
                             select p.Price;
            foreach (var item in kqSelect02)
            {
                Console.WriteLine(item);
            }


            // Có thể dùng để trả ra các kiểu vo danh tự định nghĩa
            Console.WriteLine("Select new");
            var kqSelect03 = products.Select((p) =>
            {
                return new
                {
                    Ten = p.Name,
                    Gia = p.Price
                };
            });
            /*
             Select new
            { Ten = Bàn trà, Gia = 400 }
            { Ten = Tranh treo, Gia = 400 }
            { Ten = Dèn trùm, Gia = 500 }
            { Ten = Bàn h?c, Gia = 200 }
            { Ten = Túi da, Gia = 300 }
            { Ten = Giu?ng ng?, Gia = 500 }
            { Ten = T? áo, Gia = 600 }
             */

            foreach (var item in kqSelect03)
            {
                Console.WriteLine(item);
            }

            // Có thể viết dạng truy vấn
            Console.WriteLine("Select new query");
            var kqSelect04 = from p in products
                             select new
                             {
                                 Ten = p.Name,
                                 Gia = p.Price
                             };

            foreach (var item in kqSelect04)
            {
                Console.WriteLine(item);
            }





            /*
                Where: 
                Lấy ra 1 phần của danh sách có điều kiện thỏa mãn VD lấy các sản phẩm có giá < 200
                Các phần tử sẽ chạy qua delegate nếu trả về true thì đưa vào danh sách mới 
            */
            Console.WriteLine();
            Console.WriteLine("Where query");
            var kqWhere = products.Where(p =>
            {
                return p.Name.Contains("tr");
            });

            foreach (var item in kqWhere)
            {
                Console.WriteLine(item);
            }
            /*
             * Where query
              1      Bàn trà   400  2 Xám,Xanh
              2   Tranh treo   400  1 Vàng,Xanh
              3     Dèn trùm   500  3 Tr?ng
             */
            //Co the viet duoi dang query
            Console.WriteLine("Where query");

            var kqWhere01 = from p in products where p.Name.Contains("tr") select p;
            foreach (var item in kqWhere01)
            {
                Console.WriteLine(item);
            }


            /*
                Join:
                Cho phep lấy phần chung của 2 danh sách và trả về 1 danh sách phần tử
                ** Lưu ý vì chỉ lấy phần chung nên phần không chung ở 2 bảng sẽ bị loại bỏ
                ;
            */
            Console.WriteLine();
            var kq33 = from p in products
                       join b in brands
                       on p.Brand equals b.ID
                       select new
                       {
                           Ten = p.Name,
                           ThuongHieu = b.Name
                       };
            foreach (var item in kq33)
            {
                Console.WriteLine(item);
            }
            var kq3 = products.Join(// danh sách chính
                brands,             // danh sách phụ cần join
                p => p.Brand,       // phần cần so sánh tại danh sách 1
                b => b.ID,          // phần cần so sánh tại danh sách 2
                (p, b) =>           // delegate trả về giá trị nào đó
                {
                    return new
                    {
                        Ten = p.Name,
                        ThuongHieu = b.Name
                    };
                });
            foreach (var item in kq3)
            {
                Console.WriteLine(item);
            }
            /*
                { Ten = Bàn trà, ThuongHieu = Công ty BBB }
                { Ten = Tranh treo, ThuongHieu = Công ty AAA }
                { Ten = Bàn h?c, ThuongHieu = Công ty AAA }
                { Ten = Túi da, ThuongHieu = Công ty BBB }
                { Ten = Giu?ng ng?, ThuongHieu = Công ty BBB }
             */

            /* 
                GroupJoin:
                Hoạt đọng như join nhưng các phần tử trả về 1 nhóm được nhóm lại theo nhóm ban đầu(phần cần so sánh tại danh sách 1)
                VD: sap xep cac san pham theo ten cong ty brand
            */
            Console.WriteLine();
            Console.WriteLine("Ket qua group join");
            var kqGouopJoin = brands.GroupJoin(
                products,
                b => b.ID, // phan duoc goi la key
                p => p.Brand,
                (brands, pro) => new // tham so brands la key duoc lay ra de tao nhom
                {
                    ThuongHieu = brands.Name,
                    CacSanPham = pro
                }
                );
            foreach (var item in kqGouopJoin)
            {
                Console.WriteLine(item.ThuongHieu);
                foreach (var i in item.CacSanPham)
                {
                    Console.WriteLine(i.Name);
                }
            }
            var kqGroupJoinQuery = from b in brands // key
                                   join p in products
                                   on b.ID equals p.Brand
                                   into brand // tham so brand la phan duoc lay ra de tao nhom goi tu key
                                   select new
                                   {
                                       ThuongHieu = brand,
                                       CacSanPham = products
                                   };

            foreach (var item in kqGouopJoin)
            {
                Console.WriteLine(item.ThuongHieu);
                foreach (var i in item.CacSanPham)
                {
                    Console.WriteLine(i.Name);
                }
            }
            /*
             *  Công ty AAA
                Tranh treo
                Bàn h?c

                Công ty BBB
                Bàn trà
                Túi da
                Giu?ng ng?

                Công ty CCC
             */


            /*
                Take(n) : 
                lấy n phần tử đầu tiên VD lấy 4 phần tử đầu tiên trong product
             */
            Console.WriteLine("\nTake 4");
            products.Take(4).ToList().ForEach(p => Console.WriteLine(p));


            /*
                Skip(n):
                Bỏ qua n phần tử đầu tiên
             */
            Console.WriteLine("\nSkip 2");
            products.Skip(2).ToList().ForEach(p => Console.WriteLine(p));

            /*
                OrderBy(tăng dần)/ OrderByDescending(Giảm dần) / ThenBy() / ThenByDescending()
             */
            Console.WriteLine("\nOrder by price");
            products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("\nOrder by price then desending by name");
            products.OrderBy(p => p.Price).ThenByDescending(p => p.Name).ToList().ForEach(p => Console.WriteLine(p));

            var kqOrderByQuery = from p in products
                                 orderby p.Price ascending, p.Name descending
                                 select p;
            Console.WriteLine("\nOrder by price then desending by name query");
            kqOrderByQuery.ToList().ForEach(p => Console.WriteLine(p));

            /*
             Reverse đảo ngược
             */

            //products.Reverse();

            /*
                GroupBy nhóm các phần tử trong danh sách được chọn theo 1 phần tử(key)
             */

            Console.WriteLine("\nGroup by price");
            var kqGroupBy = products.GroupBy(p => p.Price);
            foreach (var item in kqGroupBy)
            {
                Console.WriteLine($"Nhóm tuổi {item.Key}");
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\nOrdered Group by price");
            var kqGroupBy1 = products.OrderBy(p => p.Price).GroupBy(p => p.Price);
            foreach (var item in kqGroupBy1)
            {
                Console.WriteLine($"Nhóm tuổi {item.Key}");
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }

            var kqGroupByQuery = from p in products
                                 orderby p.Price ascending, p.Name descending
                                 group p by p.Price into gr
                                 select gr;

            Console.WriteLine("\nOrdered Group by price query");
            foreach (var item in kqGroupByQuery)
            {
                Console.WriteLine($"Nhóm tuổi {item.Key}");
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }

            /*
                SelectMany : cũng như select trả về phần danh sách nào đó rồi đưa vào tập hợp mới
                SelectMany có hiệu quả khi trong tập hợp có 1 danh sách ta sẽ chọn các danh sách đó và đưa ra tất cả các phần tử vào 1 danh sách mới
             */
            Console.WriteLine("\nSelect many color");
            products.SelectMany(p =>
            {
                return p.Colors;
            }).ToList().ForEach(p => Console.WriteLine(p));

            /*
                Distinct:
                Chọn ra danh sách không trùng nhau kiểu đại diện
             */
            Console.WriteLine("\nDistinct color");
            products.SelectMany(p => p.Colors).Distinct().ToList().ForEach(p => Console.WriteLine(p));

            Console.WriteLine("\nDistinct color query");
            var kqDistinct = (from p in products
                              from color in p.Colors
                              select color).Distinct();
            kqDistinct.ToList().ForEach(p => Console.WriteLine(p));


            /*
                Single & SingleOrDefault:
                Duyệt tìm trong danh sách 1 phần tử 'duy nhất' thỏa mãn điều kiện nếu có nhiều hơn 1 phần tử hoặc không tìm thấy thì
                Single(delegate điều kiện) : phát sinh lỗi 
                SingleOrDefault(delegate điều kiện): không phát sinh lỗi trả về null
             */
            var kqSingle = products.Single(p => p.Price == 600);
            var kqSingleOrD = products.SingleOrDefault(p => p.Price == 1000);


            /*
                Any(delegate điều kiện): 
                Là 1 phương thức trả về giá trị boolean nếu 'ít nhất 1' phần tử thỏa mãn đk trả về true ngược lại trả về false
             */
            Console.WriteLine("\nAny price == 1000");
            var kqAny = products.Any(p => p.Price == 1000);
            Console.WriteLine(kqAny);

            /*
                All(delegate điều kiện)
                Là 1 phương thức trả về giá trị boolean nếu ít nhất 'tất cả' phần tử thỏa mãn đk trả về true ngược lại trả về false 
             */
            var kqAll = products.All(p => p.Price > 100);

            /*
                Count(delegate điều kiện hoặc không): 
                Đếm số phần tử trong danh sách thỏa mãn điều kiện và trả về 
             */
            var kqCount = products.Count(p => p.Price >= 300);

            // In ra tên sản phẩm tên thương hiệu có giá 300 - 400 giá giảm dần
            var kqQuery = from p in products
                          join b in brands
                          on p.Brand equals b.ID
                          orderby p.Price descending
                          where p.Price >= 300 && p.Price <= 400
                          select new
                          {
                              Name = p.Name,
                              Brand = b.Name,
                              Price = p.Price
                          };

            foreach (var item in kqQuery)
            {
                Console.WriteLine(item);
            }


            /*
             * Linq
                1, xác định nguồn : from tênphầntử(do chúng ta đặt) in một lớp kế thừa từ IEnumerable
                    ... where, order by...
                2, Lấy dữ liệu ra: select, groupby, ...
             */
            var kqGroupBy2 = (from p in products
                              join b in brands
                             on p.Brand equals b.ID
                              select new
                              {
                                  Product = p,
                                  Brand = b
                              });
            var kqGroupBy3 = kqGroupBy2.ToList().GroupBy(p => p.Product.Price).OrderBy(p => p.Key).ToList();


            foreach (var item in kqGroupBy2)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (var item in kqGroupBy3)
            {
                Console.WriteLine(item.Key);
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }

            /*
             * Kĩ thuật left join 
             * VD Lấy hết tất cả sản phẩm và brand của chúng nếu không có hãy để brand là noBrand
             */

            var ketqua = from product in products
                         join brand in brands on product.Brand equals brand.ID into t
                         from brand in t.DefaultIfEmpty()
                         select new
                         {
                             name = product.Name,
                             brand = (brand == null) ? "NO-BRAND" : brand.Name,
                             price = product.Price
                         };
        }
    }
}