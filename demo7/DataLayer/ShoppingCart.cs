using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ShoppingCart
    {
        [Key]
        public Guid Id { set; get; }
        [NotMapped]
        public double Total { set; get; }
        public DateTime Date { set; get; }
        public string Description { set; get;  }
        public ICollection<Product> Products { get; set; }

        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            Products = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            if(product != null)
            {
                Products.Add(product);
            }
        }

        public void RemoveFromCartById(Guid guid)
        {
            if ((Products.First(p => p.Id == guid)) != null)
            {
                Products.Remove(Products.First(p => p.Id == guid));
            }
        }

        public ICollection<Product> GetAllProducts()
        {
            return Products.ToList();
        }

        public Product GetById(Guid id)
        {
           return Products.First(p => p.Id == id);
        }

    }
}
