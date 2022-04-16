using E_Commerce.Business.Abstract;
using E_Commerce.Entities.Concrete;
using E_Commerce.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Commerce.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            var cartline = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartline!= null)
            {
                cartline.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product=product,Quantity=1});
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
        }
    }
}
