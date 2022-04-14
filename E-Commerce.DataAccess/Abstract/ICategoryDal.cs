using E_Commerce.Core.DataAccess;
using E_Commerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
