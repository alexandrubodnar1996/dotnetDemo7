using System;
using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IShopCartRepository
    {
        Guid Create();
        void AddProduct(Guid shopCartId, Product product);
        void RemoveById(Guid shopCartId, Guid guid);
        ICollection<Product> GetAllProducts(Guid shopCartId);
        Product GetById(Guid shopCartId, Guid productId);
    }
}
