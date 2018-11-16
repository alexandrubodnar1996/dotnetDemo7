using System;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
	public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _appContext;

        public ProductRepository(ApplicationContext applicationContext)
        {
            _appContext = applicationContext;
        }

        public Guid Create()
        {
            Product product = new Product();
            return product.Id;
        }

		public int GetById(Guid ProductId)
        {
            Product product = _appContext.Set<Product>().Where(p => p.Id == ProductId).FirstOrDefault();
            return product;
        }

		public void RemoveById(Guid ProductId)
        {
            Products.Remove(Products.First(p => p.Id == guid));
        }

    }
}