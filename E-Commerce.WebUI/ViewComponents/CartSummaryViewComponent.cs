using E_Commerce.WebUI.Models;
using E_Commerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace E_Commerce.WebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private ICartSessionService _cartSession;

        public CartSummaryViewComponent(ICartSessionService cartSession)
        {
            _cartSession = cartSession;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSession.GetCart()
            };
            return View(model);
        }
    }
}
