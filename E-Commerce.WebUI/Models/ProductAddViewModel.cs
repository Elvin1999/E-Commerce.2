using E_Commerce.Entities.Concrete;
using System.Collections.Generic;

namespace E_Commerce.WebUI.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}
