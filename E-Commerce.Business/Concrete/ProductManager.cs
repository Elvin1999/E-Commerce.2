using E_Commerce.Business.Abstract;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.DataAccess.Concrete;
using E_Commerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();

        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId==0);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
