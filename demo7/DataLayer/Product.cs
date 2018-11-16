using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class Product
    {
        [Key]
        public Guid Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int Pieces { set; get; }
        public double Total { private set; get; }

        public Guid ShoppingCartId { set; get; }
        public ShoppingCart ShoppingCart { set; get; }

        public Product()
        {
            Total = Price * Pieces;
        }


    }
}
