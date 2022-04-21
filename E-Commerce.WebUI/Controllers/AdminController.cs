using E_Commerce.Business.Abstract;
using E_Commerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(productViewModel);
        }
    }
}
