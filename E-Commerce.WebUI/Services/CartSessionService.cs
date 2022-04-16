using E_Commerce.Northwind.Entities.Concrete;
using E_Commerce.WebUI.ExtentionMethods;
using Microsoft.AspNetCore.Http;

namespace E_Commerce.WebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            var cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cart == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cart;
        }

        public void SetCart(Cart cart)
        {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
