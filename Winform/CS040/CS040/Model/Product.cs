using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS040.Model
{
    //[Table("Product")] - entity.ToTable("SanPham");
    public class Product
    {
        //[Key] -  entity.HasKey(p => p.ProductId);
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("TenSanPham", TypeName = "nvarchar")]
        public string Name { get; set; }

        [Column(TypeName = "float")]
        public double Price { get; set; }

        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")] - entity.HasOne(p => p.Category);
        public Category Category { get; set; } // tạo ra khóa ngoại

        public void PrintInfo()
        {
            Console.WriteLine($"Id: " + ProductId + " Name: " + Name + " Provider: " + Price + " CateId: " + CategoryId);
            //+ " CateId: " + Category.CategoryId + " CateName: " + Category.Name
        }
    }

    /*
     * Để xác định class là bảng nào trong databse : [Table("Tên Bảng")]
     * Để xác định đâu là khóa chính [Key] đặt trước thuôc tính
     * Để notnull [Required]
     * Khi ta khai báo 1 thuộc tính là string nó tương đương với nvarchar ta có thể cài đặt max length cho nó [StringLength(50)]
     * Thiết lập kiểu dữ liệu và tên cột trên database [Column("Tên cột", TypeName = "nvarchar")]
     * 
     * 
     * Muôn khai báo 1 khóa ngoại biểu diễn quan hệ giữa các entity thì ta cần khai báo 1 thuộc tính có kiểu đó trong class
     * Khi khai báo khóa ngoại sẽ mặc định có tên giống như khóa chính ở entity khác nếu muốn đổi tên ta cần thêm [ForeignKey("Tên")] để đặt lại tên
     * Kể cả khi ta không sửa đổi gì ta vẫn nên đặt 1 thuộc tính có trường giống khóa ngoại và tên giống [ForeignKey("Tên")] để có thể dễ dàng truy vấn 
     *  khi ta không lấy hết thuộc tính của class quan hệ
     */
}
