using System;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class ShopCartRepository : IShopCartRepository
    {
        private readonly ApplicationContext _appContext;

        public ShopCartRepository(ApplicationContext applicationContext)
        {
            _appContext = applicationContext;
            for (int index = 0; index < 10; index++)
            {
                Create();
            }
        }

        public Guid Create()
        {
            ShoppingCart shoppingCart = new ShoppingCart(Guid.NewGuid());
            shoppingCart.Description = " DEfault";
            _appContext.Set<ShoppingCart>().Add(shoppingCart);
            return shoppingCart.Id;
        }

        public void AddProduct(Guid shopCartId, Product product)
        {
            ShoppingCart shoppingCart = _appContext.Set<ShoppingCart>().Where(sc => sc.Id == shopCartId).FirstOrDefault();
            shoppingCart.AddToCart(product);
        }

        public Product GetById(Guid shopCartId, Guid productId)
        {
            ShoppingCart shoppingCart = _appContext.Set<ShoppingCart>().Where(sc => sc.Id == shopCartId).FirstOrDefault();
            return shoppingCart.GetById(productId);
        }

        public void RemoveById(Guid shopCartId, Guid productGuid)
        {
            ShoppingCart shoppingCart = _appContext.Set<ShoppingCart>().Where(sc => sc.Id == shopCartId).FirstOrDefault();
            shoppingCart.RemoveFromCartById(productGuid);
        }

        public ICollection<Product> GetAllProducts(Guid shopCartId)
        {
            ShoppingCart shoppingCart = _appContext.Set<ShoppingCart>().Where(sc => sc.Id == shopCartId).FirstOrDefault();
            return shoppingCart.GetAllProducts();
        }

        public ICollection<ShoppingCart> GetAllShopCarts()
        {
            return _appContext.Set<ShoppingCart>().ToList();
        }

    }
}
