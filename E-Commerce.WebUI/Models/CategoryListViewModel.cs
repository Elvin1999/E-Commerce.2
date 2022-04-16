using E_Commerce.Entities.Concrete;
using System.Collections.Generic;

namespace E_Commerce.WebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; internal set; }
    }
}