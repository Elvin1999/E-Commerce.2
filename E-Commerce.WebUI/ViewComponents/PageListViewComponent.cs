using E_Commerce.Business.Abstract;
using E_Commerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;

namespace E_Commerce.WebUI.ViewComponents
{
    public class PageListViewComponent:ViewComponent
    {
        private IProductService _productService;

        public PageListViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public ViewViewComponentResult Invoke()
        {
            var currentPage = HttpContext.Request.Query["page"];
            var category=HttpContext.Request.Query["category"];
            var canConvertCategory = int.TryParse(category, out int resultCategory);
            
            var canConvert = int.TryParse(currentPage, out int result);
            if (!canConvert)
            {
                result = 1;
            }
            var count = 0;
            if (canConvertCategory)
            {
            count = (int)Math.Ceiling(_productService.GetByCategory(resultCategory).Count/10.0d);
            }
            else
            {
                count = (int)Math.Ceiling(_productService.GetAll().Count / 10.0d);
            }
            var pages = new List<int>();
            for (int i = 1; i <=count; i++)
            {
                pages.Add(i);
            }
            var model = new PageListViewModel
            {
               Pages=pages,
               CurrentPage = result,
               Category= resultCategory
            };
            return View(model);
        }
    }
}
