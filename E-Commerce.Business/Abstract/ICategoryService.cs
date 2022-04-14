using E_Commerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
