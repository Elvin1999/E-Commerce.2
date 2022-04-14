using E_Commerce.Core.DataAccess.EntityFramework;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.DataAccess.Concrete
{
   public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
