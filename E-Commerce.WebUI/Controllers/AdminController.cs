using E_Commerce.Business.Abstract;
using E_Commerce.Entities.Concrete;
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
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            return View();
        }
    }
}
