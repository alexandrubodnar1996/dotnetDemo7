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

		public void RemoveById(Guid Id)
        {

        }

    }
}