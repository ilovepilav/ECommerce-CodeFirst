using ECommerce_CodeFirst.DAL.Entities;
using ECommerce_CodeFirst.DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Context
{
    public class ProjectContext:DbContext
    {
        
        private string connectionString = "Server=localhost;Database=ECommerceCodeFirstDb;Integrated Security=True;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderSale>().HasKey(ors=>new {ors.OrderId, ors.ProductId });
            
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderSale> OrderSale { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
    }
}
