using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        DbSet<ShoppingCart> ShoppingCarts { set; get; }
        DbSet<Product> Products { set; get; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<ShoppingCart>().Property(sc => sc.Id).IsRequired();
            model.Entity<Product>().Property(p => p.Id).IsRequired();
        }
    }
}
