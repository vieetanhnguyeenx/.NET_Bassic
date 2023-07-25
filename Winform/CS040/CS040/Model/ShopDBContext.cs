using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS040.Model
{
    public class ShopContext : DbContext
    {
        public static ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            //builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information);
            builder.AddConsole();
        });

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }


        private const string connectString = @"
            Data Source=localhost,1433;
            Initial Catalog=shopdata;
            User ID=sa;
            Password=sa;
            TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(connectString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var entity = modelBuilder.Entity<Product>(entity =>
            {
                //Table mapping
                entity.ToTable("SanPham");
                // Primarykey
                entity.HasKey(p => p.ProductId);

                // Index
                entity.HasIndex(p => p.Price).HasDatabaseName("index-sanpham-price");

                //Relative
                //Để thiết lập mối quan hệ 1 nhiều với bảng category ta cần tạo ra 1 đối tượng category
                // Sau đó chỉ ra đối tượng quan hệ trong HasOne(phần 1)
                entity.HasOne(p => p.Category)
                .WithMany()                     // Category khong co properties cua san pham
                .HasForeignKey("CategoryId")    // Dặt tên cho fk trên database
                .OnDelete(DeleteBehavior.NoAction); // khi xoa phần 1 thì phần nhiều làm gì khi xóa cate thì product làm gì
                ;
            });
        }
    }
}
