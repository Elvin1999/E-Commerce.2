using E_Commerce.Business.Abstract;
using E_Commerce.Northwind.Entities.Concrete;
using E_Commerce.WebUI.Models;
using E_Commerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService,
            ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", string.Format("Your product , {0} was added successfully ", productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");

        }

        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            var cartSummaryViewModel = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(cartSummaryViewModel);
        }

        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message","Your product was removed successfully ");
            return RedirectToAction("List");
        }
        public IActionResult Complete()
        {
            var shippingDetailsModel = new ShippingDetailsModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsModel);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", string.Format("Thank you {0} , you order is in process", shippingDetails.Firstname));
            return View();
        }
    }
}
