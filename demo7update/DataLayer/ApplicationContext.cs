using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();

        }

        DbSet<ShoppingCart> ShoppingCarts { set; get; }
        DbSet<Product> Products { set; get; }

        protected override void OnModelCreating(ModelBuilder options)
        {
            options.Entity<ShoppingCart>().Property(sc => sc.Id).IsRequired();
            options.Entity<Product>().Property(p => p.Id).IsRequired();

        }
    }
}
