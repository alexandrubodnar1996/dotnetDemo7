using System;
using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IProductRepository
    {
        Guid Create();
        //void AddProduct(Guid shopCartId, Product product);
        void RemoveById(Guid Id);
        //ICollection<Product> GetAllProducts(Guid shopCartId);
        Product GetById(Guid productId);
    }
}
