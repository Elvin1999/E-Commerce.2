using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace E_Commerce.WebUI.Models
{
    public class PageListViewModel
    {
        public List<int> Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}