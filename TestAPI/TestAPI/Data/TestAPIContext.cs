using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    public class TestAPIContext : DbContext
    {
        public TestAPIContext (DbContextOptions<TestAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderToProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId});

            modelBuilder.Entity<OrderToProduct>().HasOne(x => x.Product).WithMany(x => x.OrderToProductList).HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<OrderToProduct>().HasOne(x => x.Order).WithMany(x => x.OrderToProductList).HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Price = 10, Qty = 1, Total = 1 },
                new Product { Id = 2, Price = 14, Qty = 21, Total = 1 },
                new Product { Id = 3, Price = 12, Qty = 21, Total = 1 },
                new Product { Id = 4, Price = 15, Qty = 1, Total = 1 },
                new Product { Id = 5, Price = 16, Qty = 1, Total = 1 },
                new Product { Id = 6, Price = 17, Qty = 31, Total = 1 },
                new Product { Id = 7, Price = 12, Qty = 14, Total = 1 },
                new Product { Id = 8, Price = 13, Qty = 1, Total = 1 },
                new Product { Id = 9, Price = 14, Qty = 1, Total = 1 },
                new Product { Id = 10, Price = 15, Qty = 41, Total = 1 },
                new Product { Id = 11, Price = 16, Qty = 1, Total = 1 },
                new Product { Id = 12, Price = 12, Qty = 15, Total = 1 },
                new Product { Id = 13, Price = 13, Qty = 1, Total = 1 },
                new Product { Id = 14, Price = 10, Qty = 1, Total = 1 },
                new Product { Id = 15, Price = 14, Qty = 15, Total = 1 },
                new Product { Id = 16, Price = 12, Qty = 2, Total = 1 },
                new Product { Id = 17, Price = 30, Qty = 1, Total = 1 },
                new Product { Id = 18, Price = 40, Qty = 2, Total = 1 },
                new Product { Id = 19, Price = 50, Qty = 61, Total = 1 },
                new Product { Id = 20, Price = 20, Qty = 1, Total = 1 },
                new Product { Id = 21, Price = 50, Qty = 1, Total = 1 },
                new Product { Id = 22, Price = 20, Qty = 1, Total = 1 },
                new Product { Id = 23, Price = 50, Qty = 11, Total = 1 },
                new Product { Id = 24, Price = 10, Qty = 1, Total = 1 },
                new Product { Id = 25, Price = 10, Qty = 1, Total = 1 },
                new Product { Id = 26, Price = 30, Qty = 41, Total = 1 },
                new Product { Id = 27, Price = 40, Qty = 10, Total = 1 },
                new Product { Id = 28, Price = 60, Qty = 100, Total = 1 },
                new Product { Id = 29, Price = 20, Qty = 18, Total = 1 },
                new Product { Id = 30, Price = 40, Qty = 15, Total = 1 }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, Date = DateTime.Now, Status = 0, Total = 10 },
                new Order { Id = 2, Date = DateTime.Now, Status = 0, Total = 15 },
                new Order { Id = 3, Date = DateTime.Now, Status = 1, Total = 20 },
                new Order { Id = 4, Date = DateTime.Now, Status = 1, Total = 100 },
                new Order { Id = 5, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 6, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 7, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 8, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 9, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 10, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 11, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 12, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 13, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 14, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 15, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 16, Date = DateTime.Now, Status = 1, Total = 0 },
                new Order { Id = 17, Date = DateTime.Now, Status = 1, Total = 0 }
            );

            modelBuilder.Entity<OrderToProduct>().HasData(
                new OrderToProduct { OrderId = 1, ProductId = 1 },
                new OrderToProduct { OrderId = 1, ProductId = 2 },
                new OrderToProduct { OrderId = 1, ProductId = 3 },
                new OrderToProduct { OrderId = 1, ProductId = 4 },
                new OrderToProduct { OrderId = 1, ProductId = 5 },
                new OrderToProduct { OrderId = 1, ProductId = 6 },
                new OrderToProduct { OrderId = 1, ProductId = 7 },
                new OrderToProduct { OrderId = 1, ProductId = 8 },
                new OrderToProduct { OrderId = 1, ProductId = 9 },
                new OrderToProduct { OrderId = 1, ProductId = 10 },
                new OrderToProduct { OrderId = 1, ProductId = 11 },
                new OrderToProduct { OrderId = 1, ProductId = 12 },
                new OrderToProduct { OrderId = 1, ProductId = 13 },
                new OrderToProduct { OrderId = 1, ProductId = 14 },
                new OrderToProduct { OrderId = 1, ProductId = 15 },
                new OrderToProduct { OrderId = 1, ProductId = 16 },
                new OrderToProduct { OrderId = 1, ProductId = 17 },
                new OrderToProduct { OrderId = 1, ProductId = 18 },
                new OrderToProduct { OrderId = 1, ProductId = 19 },
                new OrderToProduct { OrderId = 1, ProductId = 20 },
                new OrderToProduct { OrderId = 1, ProductId = 21 },
                new OrderToProduct { OrderId = 1, ProductId = 22 },
                new OrderToProduct { OrderId = 1, ProductId = 23 },
                new OrderToProduct { OrderId = 1, ProductId = 24 },
                new OrderToProduct { OrderId = 1, ProductId = 25 },
                new OrderToProduct { OrderId = 1, ProductId = 26 },
                new OrderToProduct { OrderId = 1, ProductId = 27 },
                new OrderToProduct { OrderId = 1, ProductId = 28 },
                new OrderToProduct { OrderId = 1, ProductId = 29 },
                new OrderToProduct { OrderId = 2, ProductId = 1 },
                new OrderToProduct { OrderId = 2, ProductId = 15 },
                new OrderToProduct { OrderId = 2, ProductId = 14 },
                new OrderToProduct { OrderId = 2, ProductId = 2 },
                new OrderToProduct { OrderId = 2, ProductId = 3 },
                new OrderToProduct { OrderId = 2, ProductId = 30 },
                new OrderToProduct { OrderId = 4, ProductId = 5 },
                new OrderToProduct { OrderId = 4, ProductId = 7 },
                new OrderToProduct { OrderId = 4, ProductId = 27 },
                new OrderToProduct { OrderId = 4, ProductId = 24 }
            );


        }
    }
}
